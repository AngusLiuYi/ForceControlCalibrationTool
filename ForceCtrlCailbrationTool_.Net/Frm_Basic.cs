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
            _IsEnableGuide = isEnableGuide;
        }
        private int _IsEnableGuide;
        private string CsvFilePath = @"..\..\..\Data";
        private void Frm_Basic_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Basic_Shown(object sender, EventArgs e)
        {
            //非引导模式下搜索data文件夹内是否存在标定数据备份
            string csvFileName = AngusTools.FileHelper.CfgHelper.GetCfgValue(CsvFilePath + "\\Config.config", "DriveType");
            string[] strs = Directory.GetFiles(CsvFilePath, "*" + csvFileName + ".csv");
            if (strs.Length <= 0)
                return;
            DialogResult res = AntdUI.Modal.open(this,
                                    "存在数据备份",
                                    "检测到本地存在标定数据备份，是否加载？");
            if (res != DialogResult.OK)
                return;
            Frm_BackupSelect frm_BackupSelect = new Frm_BackupSelect(strs);
            if (frm_BackupSelect.ShowDialog() == DialogResult.OK)
                LoadBackupFile(strs[frm_BackupSelect.SelectedFilesValue]);
        }

        private void LoadBackupFile(string path)
        {

        }
    }
}
