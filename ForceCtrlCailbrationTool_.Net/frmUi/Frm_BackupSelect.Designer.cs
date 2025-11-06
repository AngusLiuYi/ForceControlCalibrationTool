namespace ForceCtrlCailbrationTool_.Net_x._0_.frmUi
{
    partial class Frm_BackupSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            Pan_main = new AntdUI.Panel();
            radio1 = new AntdUI.Radio();
            divider1 = new AntdUI.Divider();
            pageHeader_FrmBackupSelect = new AntdUI.PageHeader();
            Pan_main.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(218, 63);
            label2.TabIndex = 10;
            label2.Text = "根据当前选择的驱动器类型，\r\n检索到如下备份，\r\n请双击需要加载的备份文件。";
            // 
            // Pan_main
            // 
            Pan_main.ArrowSize = 10;
            Pan_main.Controls.Add(radio1);
            Pan_main.Controls.Add(divider1);
            Pan_main.Location = new Point(12, 120);
            Pan_main.Name = "Pan_main";
            Pan_main.Radius = 10;
            Pan_main.Shadow = 24;
            Pan_main.ShadowOpacity = 0.18F;
            Pan_main.ShadowOpacityAnimation = true;
            Pan_main.Size = new Size(421, 197);
            Pan_main.TabIndex = 16;
            // 
            // radio1
            // 
            radio1.AutoSizeMode = AntdUI.TAutoSize.Width;
            radio1.Location = new Point(24, 27);
            radio1.Name = "radio1";
            radio1.Size = new Size(83, 48);
            radio1.TabIndex = 2;
            radio1.Text = "Option 1";
            // 
            // divider1
            // 
            divider1.BackColor = Color.Transparent;
            divider1.Dock = DockStyle.Top;
            divider1.Location = new Point(24, 24);
            divider1.Margin = new Padding(10);
            divider1.Name = "divider1";
            divider1.Size = new Size(373, 1);
            divider1.TabIndex = 1;
            // 
            // pageHeader_FrmBackupSelect
            // 
            pageHeader_FrmBackupSelect.Dock = DockStyle.Top;
            pageHeader_FrmBackupSelect.Font = new Font("Microsoft YaHei UI", 12F);
            pageHeader_FrmBackupSelect.Location = new Point(0, 0);
            pageHeader_FrmBackupSelect.MaximizeBox = false;
            pageHeader_FrmBackupSelect.MinimizeBox = false;
            pageHeader_FrmBackupSelect.Name = "pageHeader_FrmBackupSelect";
            pageHeader_FrmBackupSelect.Padding = new Padding(0, 0, 8, 0);
            pageHeader_FrmBackupSelect.ShowButton = true;
            pageHeader_FrmBackupSelect.Size = new Size(450, 36);
            pageHeader_FrmBackupSelect.SubFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            pageHeader_FrmBackupSelect.SubText = "";
            pageHeader_FrmBackupSelect.TabIndex = 21;
            pageHeader_FrmBackupSelect.Text = "加载备份文件";
            // 
            // Frm_BackupSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 330);
            Controls.Add(pageHeader_FrmBackupSelect);
            Controls.Add(Pan_main);
            Controls.Add(label2);
            Name = "Frm_BackupSelect";
            Resizable = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_BackupSelect";
            Load += Frm_BackupSelect_Load;
            Pan_main.ResumeLayout(false);
            Pan_main.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private AntdUI.Panel Pan_main;
        private AntdUI.Divider divider1;
        private AntdUI.Radio radio1;
        private AntdUI.PageHeader pageHeader_FrmBackupSelect;
    }
}