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

namespace ForceCtrlCailbrationTool_.Net_x._0_
{
    public partial class Frm_Basic : AntdUI.Window
    {
        public Frm_Basic(int isEnableGuide)
        {
            InitializeComponent();
            _IsEnableGuide= isEnableGuide;
        }
        private int _IsEnableGuide;
        private string CsvFilePath = @"..\..\..\Data";
        private void Frm_Basic_Load(object sender, EventArgs e)
        {
            //非引导模式下搜索data文件夹内是否存在标定数据备份
            string csvFileName = AngusTools.FileHelper.CfgHelper.GetCfgValue(CsvFilePath + "\\Config.config", "DriveType");
            string[] strs = Directory.GetFiles(CsvFilePath, "*" + csvFileName + ".csv");
            if (_IsEnableGuide == 2 && strs.Length != 0)
            {
                DialogResult res = AntdUI.Modal.open(this,
                                        "存在数据备份",
                                        "检测到本地存在标定数据备份，是否加载？");
                if (res == DialogResult.OK) 
                {
                    Frm_BackupSelect frm_BackupSelect = new Frm_BackupSelect(strs);
                    frm_BackupSelect.ShowDialog();
                }
            }
        }
    }
}
