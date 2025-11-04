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
            Btn_OK = new AntdUI.Button();
            Btn_Canel = new AntdUI.Button();
            label1 = new Label();
            label2 = new Label();
            Pan_main = new AntdUI.Panel();
            radio1 = new AntdUI.Radio();
            divider1 = new AntdUI.Divider();
            Pan_main.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_OK
            // 
            Btn_OK.IconSvg = "CheckOutlined";
            Btn_OK.Location = new Point(236, 323);
            Btn_OK.Name = "Btn_OK";
            Btn_OK.Size = new Size(87, 36);
            Btn_OK.TabIndex = 1;
            Btn_OK.Text = "确认";
            Btn_OK.Type = AntdUI.TTypeMini.Primary;
            // 
            // Btn_Canel
            // 
            Btn_Canel.IconSvg = "CloseOutlined";
            Btn_Canel.Location = new Point(139, 323);
            Btn_Canel.Name = "Btn_Canel";
            Btn_Canel.Size = new Size(87, 36);
            Btn_Canel.TabIndex = 4;
            Btn_Canel.Text = "取消";
            Btn_Canel.Type = AntdUI.TTypeMini.Error;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 22);
            label1.TabIndex = 9;
            label1.Text = "请选择备份";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(314, 63);
            label2.TabIndex = 10;
            label2.Text = "根据当前选择的驱动器类型，\r\n检索到如下备份，\r\n请选择一份需要加载的备份文件后点击确定";
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
            Pan_main.Size = new Size(311, 197);
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
            divider1.Size = new Size(263, 1);
            divider1.TabIndex = 1;
            // 
            // Frm_BackupSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 371);
            Controls.Add(Pan_main);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_Canel);
            Controls.Add(Btn_OK);
            Name = "Frm_BackupSelect";
            Text = "Frm_BackupSelect";
            Load += Frm_BackupSelect_Load;
            Pan_main.ResumeLayout(false);
            Pan_main.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Button Btn_OK;
        private AntdUI.Button Btn_Canel;
        private Label label1;
        private Label label2;
        private AntdUI.Panel Pan_main;
        private AntdUI.Divider divider1;
        private AntdUI.Radio radio1;
    }
}