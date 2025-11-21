using AngusTools;
using AntdUI;
using ForceCtrlCailbrationTool_.Net_x._0_.frmUi;
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

        /// <summary>
        /// 是否载入引导界面
        /// </summary>
        public int IsStartGuide = 0;

        private void Btn_StartGuide_Click(object sender, EventArgs e)
        {
            //TODO--引导实现
            //SaveConfig();
            //IsStartGuide = 1;
            //this.Close();
            AntdUI.Modal.open(this, "Error", "暂未实现引导步骤！", AntdUI.TType.Error);

        }

        private void Btn_StartOutGuide_Click(object sender, EventArgs e)
        {
            //跳过引导，直接载入主界面
            this.Hide();
            IsStartGuide = 2;
            SaveConfig();
            this.Close();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            //版本控制显示在工具栏
            pageHeader_FrmMain.SubText = Application.ProductVersion[..8];

            //读取存放的config文件，获取基本设置。
            ConfigStruct config = new();
            bool isHaveCfg = false;
            if (File.Exists(UserDataType.JsonFilePath))
            {
                config = AngusTools.FileHelper.JsonHelper.GetJson<ConfigStruct>(UserDataType.JsonFilePath);
                //如果成功读取到存档，则置位isHaveCfg
                isHaveCfg = true;
            }

            //加载驱动器类型到下拉框。该变量用于标定/验证时操作地址
            Slt_DriveType.Items.AddRange(Enum.GetNames(typeof(UserDataType.DriveType)));
            if (isHaveCfg)
                Slt_DriveType.SelectedValue = config.DriveType;
            else
                Slt_DriveType.SelectedIndex = 1;

            //加载电机类型到下拉框。预留使用，暂时无需选择
            Slt_ServoType.Items.AddRange(Enum.GetNames(typeof(UserDataType.ServoType)));
            if (isHaveCfg)
                Slt_ServoType.SelectedValue = config.ServoType;
            else
                Slt_ServoType.SelectedIndex = 0;

            //加载力控标定单位下拉框
            if (isHaveCfg)
                Slt_TorqueUnit.SelectedValue = config.TorqueUnit;
            else Slt_ServoType.SelectedIndex = 0;

            if (isHaveCfg)
                Slt_ForceUnit.SelectedValue = config.ForceUnit;
            else Slt_ServoType.SelectedIndex = 0;

            //加载反馈电流标定
            if (isHaveCfg)
            {
                if (config.EnableCailCurrent == "True")
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

        /// <summary>
        /// 驱动器类型下拉框选项更改时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Slt_DriveType_SelectedIndexChanged(object sender, IntEventArgs e)
        {

        }

        /// <summary>
        /// 存储当前页面数据到cfg文件
        /// </summary>
        private void SaveConfig()
        {
            //创建“是否同步标定反馈电流”
            var strEnableCailCurrent = "False";
            var strCurrentUnit = "null";
            if (Cb_CailCurrent.Checked)
            {
                strEnableCailCurrent = "True";
                strCurrentUnit = Slt_CurrentUnit.SelectedValue as string;
            }

            ConfigStruct jsonData = new()
            {
                DriveType = Slt_DriveType.SelectedValue.ToString(),
                ServoType= Slt_ServoType.SelectedValue.ToString(),
                TorqueUnit= Slt_TorqueUnit.SelectedValue.ToString(),
                ForceUnit= Slt_ForceUnit.SelectedValue.ToString(),
                EnableCailCurrent= strEnableCailCurrent,
                CurrentUnit= strCurrentUnit
            };
            AngusTools.FileHelper.JsonHelper.SaveToJson(UserDataType.JsonFilePath, jsonData);     
        }

        /// <summary>
        /// 基本设置配置
        /// </summary>
        public struct ConfigStruct
        {
            /// <summary>
            /// 驱动器类型
            /// </summary>
            public string DriveType { get; set; }
            /// <summary>
            /// 电机类型
            /// </summary>
            public string ServoType { get; set; }
            /// <summary>
            /// 力矩限制单位
            /// </summary>
            public string TorqueUnit { get; set; }
            /// <summary>
            /// 实际压力单位
            /// </summary>
            public string ForceUnit { get; set; }
            /// <summary>
            /// 使能电流反馈标定
            /// </summary>
            public string EnableCailCurrent { get; set; }
            /// <summary>
            /// 电流反馈单位
            /// </summary>
            public string CurrentUnit { get; set; }
        }
    }

}
