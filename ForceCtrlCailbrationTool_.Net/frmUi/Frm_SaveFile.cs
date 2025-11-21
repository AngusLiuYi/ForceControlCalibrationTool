using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForceCtrlCailbrationTool_.Net_x._0_.frmUi
{
    public partial class Frm_SaveFile : AntdUI.Window
    {
        public Frm_SaveFile()
        {
            InitializeComponent();
        }

        public string FileName;
        private void Btn_Save_Click(object sender, EventArgs e)
        {

            //连接文件路径
            string _fileName;
            if (string.IsNullOrEmpty(FileNameInput.Text))
                _fileName = FileNameInput.PlaceholderText + FileNameInput.SuffixText;
            else _fileName = FileNameInput.Text + FileNameInput.SuffixText;

            //如果当前文件下存在同名备份，提示用户是否覆盖
            if (File.Exists(UserDataType.CsvFilePath + _fileName))
            {
                if (AntdUI.Modal.open(this, "是否覆盖？", "检测到备份文件夹存在同名文件，请确认是否覆盖？") != DialogResult.OK) 
                    return;
            }
            FileName = _fileName;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
