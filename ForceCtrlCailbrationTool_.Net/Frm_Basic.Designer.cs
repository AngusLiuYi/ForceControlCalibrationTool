namespace ForceCtrlCailbrationTool_.Net_x._0_
{
    partial class Frm_Basic
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
            pageHeader_FrmMain = new AntdUI.PageHeader();
            SuspendLayout();
            // 
            // pageHeader_FrmMain
            // 
            pageHeader_FrmMain.Dock = DockStyle.Top;
            pageHeader_FrmMain.Font = new Font("Microsoft YaHei UI", 12F);
            pageHeader_FrmMain.Location = new Point(0, 0);
            pageHeader_FrmMain.MaximizeBox = false;
            pageHeader_FrmMain.Name = "pageHeader_FrmMain";
            pageHeader_FrmMain.Padding = new Padding(0, 0, 8, 0);
            pageHeader_FrmMain.ShowButton = true;
            pageHeader_FrmMain.Size = new Size(800, 36);
            pageHeader_FrmMain.SubFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            pageHeader_FrmMain.SubText = "基本配置";
            pageHeader_FrmMain.TabIndex = 20;
            pageHeader_FrmMain.Text = "力控标定计算器";
            // 
            // Frm_Basic
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pageHeader_FrmMain);
            Name = "Frm_Basic";
            Text = "Frm_Basic";
            Load += Frm_Basic_Load;
            Shown += Frm_Basic_Shown;
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pageHeader_FrmMain;
    }
}