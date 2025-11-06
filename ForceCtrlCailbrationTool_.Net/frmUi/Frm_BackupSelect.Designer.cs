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
            pageHeader_FrmBackupSelect = new AntdUI.PageHeader();
            label2 = new Label();
            Pan_main = new AntdUI.Panel();
            radio1 = new AntdUI.Radio();
            divider1 = new AntdUI.Divider();
            Pan_main.SuspendLayout();
            SuspendLayout();
            // 
            // pageHeader_FrmBackupSelect
            // 
            pageHeader_FrmBackupSelect.Dock = DockStyle.Top;
            pageHeader_FrmBackupSelect.Font = new Font("Microsoft YaHei UI", 12F);
            pageHeader_FrmBackupSelect.Location = new Point(0, 0);
            pageHeader_FrmBackupSelect.Margin = new Padding(4);
            pageHeader_FrmBackupSelect.MaximizeBox = false;
            pageHeader_FrmBackupSelect.MinimizeBox = false;
            pageHeader_FrmBackupSelect.Name = "pageHeader_FrmBackupSelect";
            pageHeader_FrmBackupSelect.Padding = new Padding(0, 0, 10, 0);
            pageHeader_FrmBackupSelect.ShowButton = true;
            pageHeader_FrmBackupSelect.Size = new Size(484, 42);
            pageHeader_FrmBackupSelect.SubFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            pageHeader_FrmBackupSelect.SubText = "";
            pageHeader_FrmBackupSelect.TabIndex = 21;
            pageHeader_FrmBackupSelect.Text = "加载备份文件";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(0, 42);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(272, 81);
            label2.TabIndex = 22;
            label2.Text = "根据当前选择的驱动器类型，\r\n检索到如下备份，\r\n请双击需要加载的备份文件。";
            // 
            // Pan_main
            // 
            Pan_main.ArrowSize = 10;
            Pan_main.Controls.Add(radio1);
            Pan_main.Controls.Add(divider1);
            Pan_main.Dock = DockStyle.Fill;
            Pan_main.Location = new Point(0, 123);
            Pan_main.Margin = new Padding(4);
            Pan_main.Name = "Pan_main";
            Pan_main.Radius = 10;
            Pan_main.Shadow = 24;
            Pan_main.ShadowOpacity = 0.18F;
            Pan_main.ShadowOpacityAnimation = true;
            Pan_main.Size = new Size(484, 354);
            Pan_main.TabIndex = 23;
            // 
            // radio1
            // 
            radio1.AutoSizeMode = AntdUI.TAutoSize.Width;
            radio1.BackColor = Color.Transparent;
            radio1.Location = new Point(43, 47);
            radio1.Margin = new Padding(4);
            radio1.Name = "radio1";
            radio1.Size = new Size(104, 56);
            radio1.TabIndex = 2;
            radio1.Text = "Option 1";
            // 
            // divider1
            // 
            divider1.BackColor = Color.Transparent;
            divider1.Dock = DockStyle.Top;
            divider1.Location = new Point(30, 30);
            divider1.Margin = new Padding(13, 12, 13, 12);
            divider1.Name = "divider1";
            divider1.Size = new Size(424, 1);
            divider1.TabIndex = 1;
            // 
            // Frm_BackupSelect
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 477);
            Controls.Add(Pan_main);
            Controls.Add(label2);
            Controls.Add(pageHeader_FrmBackupSelect);
            Margin = new Padding(4);
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
        private AntdUI.PageHeader pageHeader_FrmBackupSelect;
        private Label label2;
        private AntdUI.Panel Pan_main;
        private AntdUI.Radio radio1;
        private AntdUI.Divider divider1;
    }
}