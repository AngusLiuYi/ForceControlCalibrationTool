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
        public Frm_BackupSelect(string[] fileNames)
        {
            InitializeComponent();
            _FileNames = fileNames;
        }
        private string[] _FileNames;
        private List<AntdUI.Radio> ListRadio = new();
        private void Frm_BackupSelect_Load(object sender, EventArgs e)
        {
            Pan_main.Controls.Clear();
            for (int i = 0; i < _FileNames.Length; i++)
            {
                Pan_main.Controls.Add(new AntdUI.Radio());
                Pan_main.Controls[i].Text = _FileNames[i];
                Pan_main.Controls[i].Location = new Point(27, 27 + 50 * i);
            }
        }
    }
}
