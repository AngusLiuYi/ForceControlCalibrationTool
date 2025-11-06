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
        public Frm_Basic(int isEnableGuide)
        {
            InitializeComponent();
            _IsEnableGuide = isEnableGuide;
        }
        private int _IsEnableGuide;
        private string CsvFilePath = @"..\..\..\Data";
        private DataTable DtCailbration, DtResult;
        private string csvFileName;

        private void Frm_Basic_Load(object sender, EventArgs e)
        {
            //版本控制显示在工具栏
            pageHeader_FrmMain.SubText += Application.ProductVersion[..8];

            csvFileName = AngusTools.FileHelper.CfgHelper.GetCfgValue(CsvFilePath + "\\Config.config", "DriveType");

        }

        private void GetResult(List<double> listX, List<double> listY, out double slope, out double intercept)
        {
            DtResult = new DataTable();
            DtResult.Columns.Add("算法");
            DtResult.Columns.Add("结果表达式");
            DtResult.Columns.Add("斜率");
            DtResult.Columns.Add("截距");
            DtResult.Columns.Add("方差");
            double variance;
            FittingData.FittingData_Method_1(listX, listY, out slope, out intercept, out variance);
            string[] res = new string[]
            {
                "最小二乘法",
                "Force = "+slope.ToString()+" * Torque + "+intercept.ToString(),
                slope.ToString(),
                intercept.ToString(),
                variance.ToString(),
            };
            DtResult.Rows.Add(res);
            Tb_Result.DataSource = DtResult;
        }

        private void Frm_Basic_Shown(object sender, EventArgs e)
        {
            //非引导模式下搜索data文件夹内是否存在标定数据备份
            string[] strs = Directory.GetFiles(CsvFilePath, "*" + csvFileName + ".csv");
            if (strs.Length <= 0)
                return;
            DialogResult res = AntdUI.Modal.open(this,
                                    "存在数据备份",
                                    "检测到本地存在标定数据备份，是否加载？");
            if (res == DialogResult.OK)
                LoadBackupFile(strs);
        }


        private void LoadBackupFile(string[] fileNames)
        {
            Frm_BackupSelect frm_BackupSelect = new Frm_BackupSelect(fileNames);
            if (frm_BackupSelect.ShowDialog() != DialogResult.OK)
                return;
            DtCailbration = AngusTools.FileHelper.CsvHelper.CsvToDataTable(fileNames[frm_BackupSelect.SelectedFilesValue]);
            Tb_DataInput.DataSource = DtCailbration;
            List<double> listForce = new();
            List<double> listTorque = new();
            List<double> listCurrent = new();

            for (int i = 0; i < DtCailbration.Rows.Count; i++)
            {
                listForce.Add(Convert.ToDouble(DtCailbration.Rows[i]["实际输出力"]));
                listTorque.Add(Convert.ToDouble(DtCailbration.Rows[i]["力矩限制"]));

            }
            double slope, intercept;
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.Add.ScatterPoints(listTorque, listForce);
            GetResult(listTorque, listForce, out slope, out intercept);
            double[] arrTorque = new double[] { listTorque[0], listTorque.Last() };
            double[] arrForce = new double[] { listTorque[0] * slope + intercept, listTorque.Last() * slope + intercept };
            formsPlot1.Plot.Add.ScatterLine(arrTorque, arrForce);
            formsPlot1.Plot.Axes.AutoScale();
            formsPlot1.Refresh();

        }

        /// <summary>
        /// 文件校验
        /// 对传入数据进行合理性校验，如校验不通过弹窗警告，否则返回True
        /// </summary>
        /// <param name="dt">数据表格</param>
        /// <returns></returns>
        private bool DataCheckout(DataTable dt)
        {
            return true;
        }

        private void Tb_DataInput_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            IContextMenuStripItem[] menuStripItems =
            [
                new AntdUI.ContextMenuStripItem("增加","增加一行数据到最下方").SetIcon("DiffOutlined"),
                new AntdUI.ContextMenuStripItem("删除","删除本行数据").SetIcon("DeleteOutlined"),
                new AntdUI.ContextMenuStripItem("加载","加载历史数据").SetIcon("FolderOpenOutlined"),
                new AntdUI.ContextMenuStripItem("保存","保存数据到备份").SetIcon("SaveOutlined"),
                new AntdUI.ContextMenuStripItemDivider(),
                new AntdUI.ContextMenuStripItem("拟合","计算拟合结果").SetIcon("FunctionOutlined"),

            ];
            AntdUI.ContextMenuStrip.open(this, e => {
                switch (e.Text)
                {
                    case "增加":
                        break;
                    case "删除":
                        break;
                    case "加载":
                        //搜索data文件夹内是否存在标定数据备份
                        string[] strs = Directory.GetFiles(CsvFilePath, "*" + csvFileName + ".csv");
                        if (strs.Length <= 0)
                        {
                            AntdUI.Modal.open(this,
                                    "未检测到备份文件",
                                    "根据当前选定的驱动器，未在指定文件夹下检测到备份文件。");
                            return;
                        }
                        LoadBackupFile(strs);
                        break;

                    case "保存":
                        if(DataCheckout(DtCailbration))
                        {
                            Frm_SaveFile frm_SaveFile = new Frm_SaveFile();
                            if (frm_SaveFile.ShowDialog() == DialogResult.OK)
                                AngusTools.FileHelper.CsvHelper.DataTableToCsv(DtCailbration, csvFileName + frm_SaveFile.FileName);
                        }
                        break;
                    case "拟合":
                        break;

                    default:
                        break;
                }
            }, menuStripItems);
        }
    }
}
