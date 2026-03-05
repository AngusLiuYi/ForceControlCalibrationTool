namespace ForceCtrlCailbrationTool_.Net_x._0_
{
    partial class Frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_StartGuide = new AntdUI.Button();
            Btn_StartOutGuide = new AntdUI.Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            Cb_CailCurrent = new AntdUI.Checkbox();
            label3 = new Label();
            pageHeader_FrmMain = new AntdUI.PageHeader();
            panel1 = new Panel();
            panel2 = new Panel();
            Slt_ForceUnit = new AntdUI.Select();
            Slt_TorqueUnit = new AntdUI.Select();
            Slt_CurrentUnit = new AntdUI.Select();
            Slt_ServoType = new AntdUI.Select();
            Slt_DriveType = new AntdUI.Select();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            checkbox1 = new AntdUI.Checkbox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_StartGuide
            // 
            Btn_StartGuide.AutoSizeMode = AntdUI.TAutoSize.Auto;
            Btn_StartGuide.BorderWidth = 1F;
            Btn_StartGuide.DefaultBack = Color.Blue;
            Btn_StartGuide.DefaultBorderColor = Color.DarkSeaGreen;
            Btn_StartGuide.Dock = DockStyle.Right;
            Btn_StartGuide.Ghost = true;
            Btn_StartGuide.IsLink = true;
            Btn_StartGuide.Location = new Point(440, 0);
            Btn_StartGuide.Margin = new Padding(5);
            Btn_StartGuide.Name = "Btn_StartGuide";
            Btn_StartGuide.ShowArrow = true;
            Btn_StartGuide.Size = new Size(128, 52);
            Btn_StartGuide.TabIndex = 6;
            Btn_StartGuide.Text = "开始引导";
            Btn_StartGuide.Click += Btn_StartGuide_Click;
            // 
            // Btn_StartOutGuide
            // 
            Btn_StartOutGuide.AutoSizeMode = AntdUI.TAutoSize.Auto;
            Btn_StartOutGuide.Dock = DockStyle.Right;
            Btn_StartOutGuide.ForeColor = Color.Blue;
            Btn_StartOutGuide.Ghost = true;
            Btn_StartOutGuide.IsLink = true;
            Btn_StartOutGuide.Location = new Point(222, 0);
            Btn_StartOutGuide.Margin = new Padding(5);
            Btn_StartOutGuide.Name = "Btn_StartOutGuide";
            Btn_StartOutGuide.ShowArrow = true;
            Btn_StartOutGuide.Size = new Size(218, 52);
            Btn_StartOutGuide.TabIndex = 7;
            Btn_StartOutGuide.Text = "继续但跳过引导界面";
            Btn_StartOutGuide.Click += Btn_StartOutGuide_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(22, 28);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 31);
            label1.TabIndex = 8;
            label1.Text = "选择驱动器类型：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(22, 95);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 31);
            label2.TabIndex = 9;
            label2.Text = "选择电机类型：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(22, 174);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(182, 31);
            label4.TabIndex = 11;
            label4.Text = "力矩限制单位：";
            // 
            // Cb_CailCurrent
            // 
            Cb_CailCurrent.AutoSizeMode = AntdUI.TAutoSize.Width;
            Cb_CailCurrent.Font = new Font("Microsoft YaHei UI", 12F);
            Cb_CailCurrent.Location = new Point(22, 299);
            Cb_CailCurrent.Margin = new Padding(5);
            Cb_CailCurrent.Name = "Cb_CailCurrent";
            Cb_CailCurrent.Size = new Size(230, 67);
            Cb_CailCurrent.TabIndex = 15;
            Cb_CailCurrent.Text = "同步标定力反馈";
            Cb_CailCurrent.CheckedChanged += Cb_CailCurrent_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(22, 248);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(182, 31);
            label3.TabIndex = 16;
            label3.Text = "实际压力单位：";
            // 
            // pageHeader_FrmMain
            // 
            pageHeader_FrmMain.Dock = DockStyle.Top;
            pageHeader_FrmMain.Font = new Font("Microsoft YaHei UI", 12F);
            pageHeader_FrmMain.Location = new Point(0, 0);
            pageHeader_FrmMain.Margin = new Padding(5);
            pageHeader_FrmMain.MaximizeBox = false;
            pageHeader_FrmMain.Name = "pageHeader_FrmMain";
            pageHeader_FrmMain.Padding = new Padding(0, 0, 12, 0);
            pageHeader_FrmMain.ShowButton = true;
            pageHeader_FrmMain.Size = new Size(568, 50);
            pageHeader_FrmMain.SubFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            pageHeader_FrmMain.SubText = "基本配置";
            pageHeader_FrmMain.TabIndex = 19;
            pageHeader_FrmMain.Text = "力控标定计算器";
            // 
            // panel1
            // 
            panel1.Controls.Add(Btn_StartOutGuide);
            panel1.Controls.Add(Btn_StartGuide);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 513);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 58);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.Controls.Add(Slt_ForceUnit);
            panel2.Controls.Add(Slt_TorqueUnit);
            panel2.Controls.Add(Slt_CurrentUnit);
            panel2.Controls.Add(Slt_ServoType);
            panel2.Controls.Add(Slt_DriveType);
            panel2.Controls.Add(Cb_CailCurrent);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 50);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(568, 463);
            panel2.TabIndex = 21;
            // 
            // Slt_ForceUnit
            // 
            Slt_ForceUnit.AllowClear = true;
            Slt_ForceUnit.Items.AddRange(new object[] { "g", "Kg", "N" });
            Slt_ForceUnit.List = true;
            Slt_ForceUnit.LocalizationPlaceholderText = "Select.{id}";
            Slt_ForceUnit.Location = new Point(250, 228);
            Slt_ForceUnit.Margin = new Padding(5);
            Slt_ForceUnit.Name = "Slt_ForceUnit";
            Slt_ForceUnit.PlaceholderText = "无文本";
            Slt_ForceUnit.SelectedIndex = 0;
            Slt_ForceUnit.SelectedValue = "g";
            Slt_ForceUnit.Size = new Size(143, 58);
            Slt_ForceUnit.TabIndex = 28;
            Slt_ForceUnit.Text = "g";
            // 
            // Slt_TorqueUnit
            // 
            Slt_TorqueUnit.AllowClear = true;
            Slt_TorqueUnit.Items.AddRange(new object[] { "百分比", "千分比", "万分比" });
            Slt_TorqueUnit.List = true;
            Slt_TorqueUnit.LocalizationPlaceholderText = "Select.{id}";
            Slt_TorqueUnit.Location = new Point(250, 155);
            Slt_TorqueUnit.Margin = new Padding(5);
            Slt_TorqueUnit.Name = "Slt_TorqueUnit";
            Slt_TorqueUnit.PlaceholderText = "无文本";
            Slt_TorqueUnit.SelectedIndex = 1;
            Slt_TorqueUnit.SelectedValue = "千分比";
            Slt_TorqueUnit.Size = new Size(143, 58);
            Slt_TorqueUnit.TabIndex = 27;
            Slt_TorqueUnit.Text = "千分比";
            // 
            // Slt_CurrentUnit
            // 
            Slt_CurrentUnit.AllowClear = true;
            Slt_CurrentUnit.Enabled = false;
            Slt_CurrentUnit.Items.AddRange(new object[] { "mA" });
            Slt_CurrentUnit.List = true;
            Slt_CurrentUnit.LocalizationPlaceholderText = "Select.{id}";
            Slt_CurrentUnit.Location = new Point(250, 303);
            Slt_CurrentUnit.Margin = new Padding(5);
            Slt_CurrentUnit.Name = "Slt_CurrentUnit";
            Slt_CurrentUnit.PlaceholderText = "电流反馈单位";
            Slt_CurrentUnit.Size = new Size(183, 58);
            Slt_CurrentUnit.TabIndex = 26;
            // 
            // Slt_ServoType
            // 
            Slt_ServoType.AllowClear = true;
            Slt_ServoType.List = true;
            Slt_ServoType.LocalizationPlaceholderText = "Select.{id}";
            Slt_ServoType.Location = new Point(250, 82);
            Slt_ServoType.Margin = new Padding(5);
            Slt_ServoType.Name = "Slt_ServoType";
            Slt_ServoType.PlaceholderText = "无文本";
            Slt_ServoType.Size = new Size(282, 58);
            Slt_ServoType.TabIndex = 25;
            // 
            // Slt_DriveType
            // 
            Slt_DriveType.AllowClear = true;
            Slt_DriveType.List = true;
            Slt_DriveType.LocalizationPlaceholderText = "Select.{id}";
            Slt_DriveType.Location = new Point(250, 9);
            Slt_DriveType.Margin = new Padding(5);
            Slt_DriveType.Name = "Slt_DriveType";
            Slt_DriveType.PlaceholderText = "无文本";
            Slt_DriveType.Size = new Size(282, 58);
            Slt_DriveType.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(22, 298);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(182, 31);
            label5.TabIndex = 16;
            label5.Text = "实际压力单位：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.Location = new Point(22, 224);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(182, 31);
            label6.TabIndex = 11;
            label6.Text = "力矩限制单位：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label7.Location = new Point(22, 145);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(182, 31);
            label7.TabIndex = 9;
            label7.Text = "选择电机类型：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label8.Location = new Point(22, 78);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(206, 31);
            label8.TabIndex = 8;
            label8.Text = "选择驱动器类型：";
            // 
            // checkbox1
            // 
            checkbox1.AutoSizeMode = AntdUI.TAutoSize.Width;
            checkbox1.Font = new Font("Microsoft YaHei UI", 12F);
            checkbox1.Location = new Point(22, 349);
            checkbox1.Margin = new Padding(5);
            checkbox1.Name = "checkbox1";
            checkbox1.Size = new Size(230, 67);
            checkbox1.TabIndex = 15;
            checkbox1.Text = "同步标定力反馈";
            checkbox1.CheckedChanged += Cb_CailCurrent_CheckedChanged;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 571);
            Controls.Add(checkbox1);
            Controls.Add(panel2);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(pageHeader_FrmMain);
            Controls.Add(label6);
            Controls.Add(label5);
            EnableHitTest = false;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "Frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "力控标定计算器";
            Load += Frm_Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Button Btn_StartGuide;
        private AntdUI.Button Btn_StartOutGuide;
        private Label label1;
        private Label label2;
        private Label label4;
        private AntdUI.Checkbox Cb_CailCurrent;
        private Label label3;
        private AntdUI.PageHeader pageHeader_FrmMain;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private AntdUI.Checkbox checkbox1;
        private AntdUI.Select Slt_ForceUnit;
        private AntdUI.Select Slt_TorqueUnit;
        private AntdUI.Select Slt_CurrentUnit;
        private AntdUI.Select Slt_ServoType;
        private AntdUI.Select Slt_DriveType;
    }
}
