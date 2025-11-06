using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;

namespace ForceCtrlCailbrationTool_.Net_x._0_.frmUi
{
    public partial class Frm_BackupSelect : AntdUI.Window
    {
        public Frm_BackupSelect(string[] filePathNames)
        {
            InitializeComponent();
            _FilePathNames = filePathNames;

        }
        private string[] _FilePathNames;
        public int SelectedFilesValue = -1;

        private void Frm_BackupSelect_Load(object sender, EventArgs e)
        {
            string[] fileNames = new string[_FilePathNames.Length];
            for (int i = 0; i < _FilePathNames.Length; i++)
            {
                fileNames[i] = Path.GetFileNameWithoutExtension(_FilePathNames[i]);
            }
            Pan_main.Controls.Clear();
            for (int i = 0; i < _FilePathNames.Length; i++)
            {
                Pan_main.Controls.Add(new AntdUI.Radio()
                {
                    AutoSize = true,
                    BackColor = Color.Transparent,
                    Tag = i,
                    Text = fileNames[i]
                });
                Pan_main.Controls[i].Location = new Point(30 + 300 * (i / 5), 30 + 50 * (i % 5));
                Pan_main.Controls[i].DoubleClick += Radios_DoubleClick;
            }
        }

        private void Radios_DoubleClick(object? sender, EventArgs e)
        {
            AntdUI.Radio? radio=sender as AntdUI.Radio;
            SelectedFilesValue = (int)(radio?.Tag ?? -1);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Btn_Canel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
