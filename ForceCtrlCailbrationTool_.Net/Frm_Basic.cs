using System;
using AntdUI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForceCtrlCailbrationTool_.Net_x._0_.frmUi;
using ScottPlot.MultiplotLayouts;

namespace ForceCtrlCailbrationTool_.Net_x._0_
{
    public partial class Frm_Basic : AntdUI.Window
    {
        /// <summary>
        /// 主界面，数据录入、计算、结果展示
        /// </summary>
        /// <param name="isEnableGuide">是否引导模式</param>
        public Frm_Basic(int isEnableGuide)
        {
            InitializeComponent();
            _IsEnableGuide = isEnableGuide;
        }

        /// <summary>
        /// 是否载入引导界面
        /// </summary>
        private readonly int _IsEnableGuide;

        private bool _EnableCailCurrent = false;

        /// <summary>
        /// 标定数据存放表
        /// </summary>
        private DataTable DtCailbration;

        /// <summary>
        /// 拟合结果存放表单
        /// </summary>
        private DataTable DtResult;

        /// <summary>
        /// config文件读取储存
        /// </summary>
        private DataRow RowCfgBackup;


        private void Frm_Basic_Load(object sender, EventArgs e)
        {
            //当前版本显示在工具栏
            pageHeader_FrmBasic.SubText += Application.ProductVersion[..8];

            //读取Config文件
            RowCfgBackup = AngusTools.FileHelper.CfgHelper.CfgToDataTable(UserDataType.CfgFilePath).Rows[0];

            //标定数据录入表格数值刷新
            //标定数据录入表格显示空值
            DtCailbration = new();
            DtCailbration.Columns.Add("序号", typeof(double));
            DtCailbration.Columns.Add("力矩限制", typeof(double));
            DtCailbration.Columns.Add("实际压力", typeof(double));
            DtCailbration.Rows.Add(1, 0, 0);
            //
            if (RowCfgBackup["EnableCailCurrent"].ToString() == "True")
            {
                _EnableCailCurrent = true;
                DtCailbration.Columns.Add("反馈电流", typeof(double));
                DtCailbration.Rows[0]["反馈电流"] = 0;
            }
            Tb_DataInput.DataSource = DtCailbration;

            //拟合结果表格数值刷新
            //存入表格，显示控制
            DtResult = new();
            DtResult.Columns.Add("算法", typeof(string));
            DtResult.Columns.Add("结果表达式", typeof(string));
            DtResult.Columns.Add("斜率", typeof(double));
            DtResult.Columns.Add("截距", typeof(double));
            DtResult.Columns.Add("方差", typeof(double));
            DtResult.Rows.Add("null", "null", 0, 0, 0);
            Tb_Result.DataSource = DtResult;

            //校验数据表格单位刷新
            //-如果需要n-unit的实际压力，则应该给add写入n值
            //--实际压力单位为用户单位
            Lb_TarForce1.SuffixText = RowCfgBackup["ForceUnit"].ToString();
            //--应设力矩限制的地址：根据驱动器类型确认
            Lb_TarTorque1.PrefixText = UserDataType.TorqueSettingAdr(Enum.Parse<UserDataType.DriveType>(RowCfgBackup["DriveType"].ToString() ?? "SAC_NP2_轴一"));
            //--应设力矩限制的单位
            Lb_TarTorque1.SuffixText = RowCfgBackup["TorqueUnit"].ToString();
        }

        /// <summary>
        /// 窗体首次显示时检测备份文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Basic_Shown(object sender, EventArgs e)
        {
            //非引导模式下搜索data文件夹内是否存在标定数据备份
            //带电流反馈与不带电流反馈的也要区分，防止标定数据异常
            string[] strs;
            if (_EnableCailCurrent)
                strs = Directory.GetFiles(UserDataType.CsvFilePath, "*" + RowCfgBackup["DriveType"] + "_C.csv");
            else strs = Directory.GetFiles(UserDataType.CsvFilePath, "*" + RowCfgBackup["DriveType"] + ".csv");

            //如果不存在备份文件，表单显示空表头
            if (strs.Length <= 0) return;

            //弹出询问是否加载备份
            DialogResult res = AntdUI.Modal.open(this,
                                    "存在数据备份",
                                    "检测到本地存在标定数据备份，是否加载？");
            if (res == DialogResult.OK) LoadBackupFile(strs);
            Tb_DataInput.SelectedIndex = 0;
        }

        /// <summary>
        /// 传入待选文件路径列表，在弹窗中供用户选择
        /// </summary>
        /// <param name="fileNames">待选文件路径列表</param>
        private void LoadBackupFile(string[] fileNames)
        {
            //创建文件选择窗口
            Frm_BackupSelect frm_BackupSelect = new(fileNames);
            if (frm_BackupSelect.ShowDialog() != DialogResult.OK)
            {
                frm_BackupSelect.Dispose();
                return;
            }

            //接收用户选择的备份文件，展示到表格中
            DtCailbration = AngusTools.FileHelper.CsvHelper.CsvToDataTable(fileNames[frm_BackupSelect.SelectedFilesValue]);
            frm_BackupSelect.Dispose();
            if (!DataCheckout(DtCailbration)) return;

            //刷新表格
            Tb_DataInput.DataSource = DtCailbration;

            //刷新图表
            ChartRefresh(true, _EnableCailCurrent);
        }


        private void ChartRefresh(bool refreshLine, bool isCurrent)
        {
            //图表绑定数据需要list格式，需要进行转换
            //数据展示点位图
            List<double> listForce = [];
            List<double> listTorque = [];
            List<double> listCurrent = [];
            foreach (DataRow row in DtCailbration.Rows)
            {
                listForce.Add(Convert.ToDouble(row["实际压力"]));
                listTorque.Add(Convert.ToDouble(row["力矩限制"]));
                if (isCurrent) listCurrent.Add(Convert.ToDouble(row["反馈电流"]));
            }

            //清除图表当前内容，增加点位图
            //TODO 同步显示电流与力的点位图实现
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.Add.ScatterPoints(listTorque, listForce);
            if (isCurrent) formsPlot1.Plot.Add.ScatterPoints(listCurrent, listForce);

            //需要拟合时，计算结果并输出线图
            if (refreshLine)
            {
                DtResult.Rows.Clear();
                Slt_MethodChange.Items.Clear();
                Pan_DataCheckout.Enabled = true;
                if (isCurrent)
                {
                    foreach (var fit in FittingData.ListFittingMethod)
                    {
                        fit(listCurrent, listForce, out string funcName, out double slope, out double intercept, out double variance);
                        double[] arrCurrent = [listCurrent[0], listCurrent.Last()];
                        double[] arrVisualForce = [listCurrent[0] * slope + intercept, listCurrent.Last() * slope + intercept];
                        formsPlot1.Plot.Add.ScatterLine(arrCurrent, arrVisualForce);
                        TbResultRefresh(true, funcName, slope, intercept, variance);
                    }
                }
                else
                {
                    foreach (var fit in FittingData.ListFittingMethod)
                    {
                        fit(listTorque, listForce, out string funcName, out double slope, out double intercept, out double variance);
                        double[] arrTorque = [listTorque[0], listTorque.Last()];
                        double[] arrForce = [listTorque[0] * slope + intercept, listTorque.Last() * slope + intercept];
                        formsPlot1.Plot.Add.ScatterLine(arrTorque, arrForce);
                        TbResultRefresh(false, funcName, slope, intercept, variance);
                        Slt_MethodChange.Items.Add(funcName + ':' + DtResult.Rows.Count);
                    }
                }
            }
            else
            {
                //Slt_MethodChange.Items.Clear();
                Pan_DataCheckout.Enabled = false;
            }

            //缩放图表达到居中效果
            formsPlot1.Plot.Axes.AutoScale();
            formsPlot1.Refresh();
        }

        private void TbResultRefresh(bool isCurrent, string fitName, double slope, double intercept, double variance)
        {
            string equation;
            if (isCurrent) equation = "VisualForce = " + slope.ToString() + " * Current + " + intercept.ToString();
            else equation = "Force = " + slope.ToString() + " * Torque + " + intercept.ToString();

            string[] res =
            [
                fitName,
                equation,
                slope.ToString(),
                intercept.ToString(),
                variance.ToString(),
            ];
            DtResult.Rows.Add(res);

            Tb_Result.DataSource = DtResult;

        }

        /// <summary>
        /// 文件校验
        /// 对传入数据进行合理性校验，如校验不通过弹窗警告，否则返回True
        /// </summary>
        /// <param name="dt">数据表格</param>
        /// <returns></returns>
        private bool DataCheckout(DataTable dt)
        {
            //TODO 未实现
            return true;
        }

        /// <summary>
        /// 对数据升序排序并更新序号
        /// </summary>
        private void DataTableSort()
        {
            //根据力矩控制列进行排序
            DtCailbration.DefaultView.Sort = "力矩限制 ASC";
            DtCailbration = DtCailbration.DefaultView.ToTable();
            //更新序号
            for (int i = 0; i < DtCailbration.Rows.Count; i++)
            {
                DtCailbration.Rows[i][0] = i + 1;
            }

            Tb_DataInput.DataSource = DtCailbration;
        }

        private void Tb_DataInput_MouseDown(object sender, MouseEventArgs e)
        {
            //鼠标在数据录入表格上按下鼠标右键后创建右键菜单
            if (e.Button != MouseButtons.Right)
                return;
            IContextMenuStripItem[] menuStripItems =
            [
                new AntdUI.ContextMenuStripItem("刷新","对数据进行排序").SetIcon("ReloadOutlined"),
                new AntdUI.ContextMenuStripItem("增加","增加一行数据到最下方").SetIcon("DiffOutlined"),
                new AntdUI.ContextMenuStripItem("删除","删除本行数据").SetIcon("DeleteOutlined"),
                new AntdUI.ContextMenuStripItemDivider(),
                new AntdUI.ContextMenuStripItem("加载","加载历史数据").SetIcon("FolderOpenOutlined"),
                new AntdUI.ContextMenuStripItem("保存","保存数据到备份").SetIcon("SaveOutlined"),
                new AntdUI.ContextMenuStripItemDivider(),
                new AntdUI.ContextMenuStripItem("拟合","计算拟合结果").SetIcon("FunctionOutlined"),

            ];

            //委托右键菜单的实现
            AntdUI.ContextMenuStrip.open(this, e =>
            {
                switch (e.Text)
                {
                    case "刷新":
                        DataTableSort();
                        break;
                    case "增加":
                        //向末尾增加一行数据，补充默认值
                        DtCailbration.Rows.Add(DtCailbration.Rows.Count + 1, 0, 0);
                        if (_EnableCailCurrent) DtCailbration.Rows[^1]["反馈电流"] = 0;
                        break;
                    case "删除":
                        //删除指定行的数据
                        DtCailbration.Rows.RemoveAt(Tb_DataInput.SelectedIndex - 1);
                        break;
                }
                switch (e.Text)
                {
                    case "加载":
                        //搜索data文件夹内是否存在标定数据备份
                        string[] strs = Directory.GetFiles(UserDataType.CsvFilePath, "*" + RowCfgBackup["DriveType"] + ".csv");
                        if (strs.Length <= 0)
                        {
                            AntdUI.Modal.open(this,
                                    "未检测到备份文件",
                                    "根据当前选定的驱动器，未在指定文件夹下检测到备份文件。");
                            return;
                        }
                        //加载备份文件
                        LoadBackupFile(strs);
                        break;

                    case "保存":
                        DataTableSort();
                        //数据校验完毕后保存数据
                        if (DataCheckout(DtCailbration))
                        {
                            Frm_SaveFile frm_SaveFile = new(RowCfgBackup["DriveType"].ToString() ?? "null", _EnableCailCurrent);
                            if (frm_SaveFile.ShowDialog() == DialogResult.OK)
                                AngusTools.FileHelper.CsvHelper.DataTableToCsv(DtCailbration, UserDataType.CsvFilePath + frm_SaveFile.FileName);
                            frm_SaveFile.Dispose();
                        }
                        break;
                    case "拟合":
                        DataTableSort();
                        if (DataCheckout(DtCailbration))
                            ChartRefresh(true, _EnableCailCurrent);
                        break;
                    default:
                        Tb_DataInput.DataSource = DtCailbration;
                        ChartRefresh(false, false);
                        break;
                }
            }, menuStripItems);
        }

        private void Lb_TarForce1_TextChanged(object sender, EventArgs e)
        {
            if (Slt_MethodChange.SelectedValue == null)
                return;
            try
            {
                string select = (string)Slt_MethodChange.SelectedValue;
                DataRow rows = DtResult.Rows[Convert.ToInt32(select[(select.IndexOf(':') + 1)..]) - 1];
                double tarForce = Convert.ToDouble(Lb_TarForce1.Text);
                Lb_TarTorque1.Text = Math.Round((tarForce - (double)rows["截距"]) / (double)rows["斜率"], 4).ToString();
            }
            catch (Exception)
            {

                Lb_TarTorque1.Text = "无结果";
            }
        }

        private void Slt_MethodChange_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            Lb_TarForce1_TextChanged(Lb_TarForce1, e);
        }

        private void Pan_DataCheckout_EnabledChanged(object sender, EventArgs e)
        {
            Lb_TarForce1_TextChanged(Lb_TarForce1, e);
        }
    }
}
