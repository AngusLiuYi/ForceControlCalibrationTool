using AntdUI;
using AngusTools;
using System.Data;
using System.Reflection;
namespace ForceCtrlCailbrationTool_.Net_x._0_
{
    public partial class Frm_Main : AntdUI.Window
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private string CfgFilePath = @"..\..\..\Data\Config.config";
        public int IsStartGuide = 0;

        private void Btn_StartGuide_Click(object sender, EventArgs e)
        {
            SaveConfig();
            IsStartGuide = 1;
            this.Close();
        }

        private void Btn_StartOutGuide_Click(object sender, EventArgs e)
        {
            this.Close();
            IsStartGuide = 2;
            SaveConfig();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            //版本控制显示在工具栏
            pageHeader_FrmMain.SubText = Application.ProductVersion[..8];

            DataTable dt = AngusTools.FileHelper.CfgHelper.CfgToDataTable(CfgFilePath);

            //加载驱动器类型到下拉框。标定/验证时操作地址
            Slt_DriveType.Items.AddRange(Enum.GetNames(typeof(UserDataType.DriveType)));
            if (dt.Columns.Contains("DriveType"))
                Slt_DriveType.SelectedValue = dt.Rows[0]["DriveType"].ToString();
            else
                Slt_DriveType.SelectedIndex = 1;

            //加载电机类型到下拉框。预留使用，暂时无需选择
            Slt_ServoType.Items.AddRange(Enum.GetNames(typeof(UserDataType.ServoType)));
            if (dt.Columns.Contains("ServoType"))
                Slt_ServoType.SelectedValue = dt.Rows[0]["ServoType"].ToString();
            else
                Slt_ServoType.SelectedIndex = 0;

            //加载力控标定单位下拉框
            if (dt.Columns.Contains("TorqueUnit")) Slt_TorqueUnit.SelectedValue = dt.Rows[0]["TorqueUnit"].ToString();
            else Slt_ServoType.SelectedIndex = 0;
            if (dt.Columns.Contains("ForceUnit")) Slt_ForceUnit.SelectedValue = dt.Rows[0]["ForceUnit"].ToString();
            else Slt_ServoType.SelectedIndex = 0;

            //加载反馈电流标定
            if (dt.Columns.Contains("EnableCailCurrent"))
            {
                if (dt.Rows[0]["EnableCailCurrent"].ToString() == "1")
                {
                    Cb_CailCurrent.Checked = true;
                    Cb_CailCurrent_CheckedChanged(Cb_CailCurrent, new BoolEventArgs(true));
                }
            }
        }

        private void Cb_CailCurrent_CheckedChanged(object sender, BoolEventArgs e)
        {
            //当"同步标定电流反馈"选项被勾选的时候，使能反馈电流单位下拉选择框
            //否则不对此单位进行选择
            if (e.Value)
            {
                Slt_CurrentUnit.Enabled = true;
                Slt_CurrentUnit.SelectedIndex = 0;
            }
            else
            {
                Slt_CurrentUnit.Enabled = false;
                Slt_CurrentUnit.SelectedIndex = -1;
            }
        }

        private void Slt_DriveType_SelectedIndexChanged(object sender, IntEventArgs e)
        {

        }

        /// <summary>
        /// 存储当前页面数据到cfg文件
        /// </summary>
        private void SaveConfig()
        {
            DataTable dt = new();
            dt.Columns.Add("DriveType");
            dt.Columns.Add("ServoType");
            dt.Columns.Add("TorqueUnit");
            dt.Columns.Add("ForceUnit");
            dt.Columns.Add("EnableCailCurrent");
            dt.Rows.Add(dt.NewRow());
            dt.Rows[0]["DriveType"] = Slt_DriveType.SelectedValue;
            dt.Rows[0]["ServoType"] = Slt_ServoType.SelectedValue;
            dt.Rows[0]["TorqueUnit"] = Slt_TorqueUnit.SelectedValue;
            dt.Rows[0]["ForceUnit"] = Slt_ForceUnit.SelectedValue;
            if (Cb_CailCurrent.Checked)
            {
                dt.Rows[0]["EnableCailCurrent"] = "1";
                dt.Columns.Add("CurrentUnit");
                dt.Rows[0]["CurrentUnit"] = Slt_CurrentUnit.SelectedValue;
            }
            else dt.Rows[0]["EnableCailCurrent"] = "0";

            AngusTools.FileHelper.CfgHelper.DataTableToCfg(CfgFilePath, dt);
        }

    }

}
