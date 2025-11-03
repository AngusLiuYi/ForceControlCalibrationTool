using AntdUI;
namespace ForceCtrlCailbrationTool_.Net_x._0_
{
    public partial class Frm_Main : AntdUI.BaseForm
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Cb_CailCurrent_CheckedChanged(object sender, BoolEventArgs e)
        {
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

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Slt_DriveType.Items.AddRange(Enum.GetNames(typeof(DriveType)));
            Slt_DriveType.SelectedIndex = 0;
            Slt_ServoType.Items.AddRange(Enum.GetNames(typeof (ServoType)));
            Slt_ServoType.SelectedIndex= 0;
        }
    }
    public enum DriveType
    {
        ISD大寰驱动器,
        SAC_NP1,
        SAC_NP2_轴一,
        SAC_NP2_轴二,
        SAC_NP4_轴一,
        SAC_NP4_轴二,
        SAC_NP4_轴三,
        SAC_NP4_轴四
    }
    public enum ServoType
    {
        Vla_Vlar系列 ,
        Dla_Dlar系列,
        电缸,
        电爪
    }
}
