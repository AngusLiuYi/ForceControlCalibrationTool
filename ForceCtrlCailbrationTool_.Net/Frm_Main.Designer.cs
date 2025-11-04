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
            Slt_DriveType = new AntdUI.Select();
            Slt_ServoType = new AntdUI.Select();
            Slt_CurrentUnit = new AntdUI.Select();
            Cb_CailCurrent = new AntdUI.Checkbox();
            label3 = new Label();
            Slt_TorqueUnit = new AntdUI.Select();
            Slt_ForceUnit = new AntdUI.Select();
            pageHeader_FrmMain = new AntdUI.PageHeader();
            SuspendLayout();
            // 
            // Btn_StartGuide
            // 
            Btn_StartGuide.AutoSizeMode = AntdUI.TAutoSize.Auto;
            Btn_StartGuide.BorderWidth = 1F;
            Btn_StartGuide.DefaultBack = Color.Blue;
            Btn_StartGuide.DefaultBorderColor = Color.DarkSeaGreen;
            Btn_StartGuide.Ghost = true;
            Btn_StartGuide.IsLink = true;
            Btn_StartGuide.Location = new Point(324, 316);
            Btn_StartGuide.Name = "Btn_StartGuide";
            Btn_StartGuide.ShowArrow = true;
            Btn_StartGuide.Size = new Size(87, 36);
            Btn_StartGuide.TabIndex = 6;
            Btn_StartGuide.Text = "开始引导";
            Btn_StartGuide.Click += Btn_StartGuide_Click;
            // 
            // Btn_StartOutGuide
            // 
            Btn_StartOutGuide.AutoSizeMode = AntdUI.TAutoSize.Auto;
            Btn_StartOutGuide.ForeColor = Color.Blue;
            Btn_StartOutGuide.Ghost = true;
            Btn_StartOutGuide.IsLink = true;
            Btn_StartOutGuide.Location = new Point(264, 358);
            Btn_StartOutGuide.Name = "Btn_StartOutGuide";
            Btn_StartOutGuide.ShowArrow = true;
            Btn_StartOutGuide.Size = new Size(147, 36);
            Btn_StartOutGuide.TabIndex = 7;
            Btn_StartOutGuide.Text = "继续但跳过引导界面";
            Btn_StartOutGuide.Click += Btn_StartOutGuide_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(26, 55);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 8;
            label1.Text = "选择驱动器类型：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(26, 103);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 9;
            label2.Text = "选择电机类型：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(26, 159);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 11;
            label4.Text = "力矩限制单位：";
            // 
            // Slt_DriveType
            // 
            Slt_DriveType.AllowClear = true;
            Slt_DriveType.List = true;
            Slt_DriveType.LocalizationPlaceholderText = "Select.{id}";
            Slt_DriveType.Location = new Point(179, 45);
            Slt_DriveType.Name = "Slt_DriveType";
            Slt_DriveType.PlaceholderText = "无文本";
            Slt_DriveType.Size = new Size(180, 41);
            Slt_DriveType.TabIndex = 12;
            Slt_DriveType.SelectedIndexChanged += Slt_DriveType_SelectedIndexChanged;
            // 
            // Slt_ServoType
            // 
            Slt_ServoType.AllowClear = true;
            Slt_ServoType.List = true;
            Slt_ServoType.LocalizationPlaceholderText = "Select.{id}";
            Slt_ServoType.Location = new Point(179, 97);
            Slt_ServoType.Name = "Slt_ServoType";
            Slt_ServoType.PlaceholderText = "无文本";
            Slt_ServoType.Size = new Size(180, 41);
            Slt_ServoType.TabIndex = 13;
            // 
            // Slt_CurrentUnit
            // 
            Slt_CurrentUnit.AllowClear = true;
            Slt_CurrentUnit.Enabled = false;
            Slt_CurrentUnit.Items.AddRange(new object[] { "mA" });
            Slt_CurrentUnit.List = true;
            Slt_CurrentUnit.LocalizationPlaceholderText = "Select.{id}";
            Slt_CurrentUnit.Location = new Point(179, 253);
            Slt_CurrentUnit.Name = "Slt_CurrentUnit";
            Slt_CurrentUnit.PlaceholderText = "电流反馈单位";
            Slt_CurrentUnit.Size = new Size(117, 41);
            Slt_CurrentUnit.TabIndex = 14;
            // 
            // Cb_CailCurrent
            // 
            Cb_CailCurrent.AutoSizeMode = AntdUI.TAutoSize.Width;
            Cb_CailCurrent.Font = new Font("Microsoft YaHei UI", 12F);
            Cb_CailCurrent.Location = new Point(26, 247);
            Cb_CailCurrent.Name = "Cb_CailCurrent";
            Cb_CailCurrent.Size = new Size(154, 48);
            Cb_CailCurrent.TabIndex = 15;
            Cb_CailCurrent.Text = "同步标定力反馈";
            Cb_CailCurrent.CheckedChanged += Cb_CailCurrent_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(26, 211);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 16;
            label3.Text = "实际压力单位：";
            // 
            // Slt_TorqueUnit
            // 
            Slt_TorqueUnit.AllowClear = true;
            Slt_TorqueUnit.Items.AddRange(new object[] { "百分比", "千分比", "万分比" });
            Slt_TorqueUnit.List = true;
            Slt_TorqueUnit.LocalizationPlaceholderText = "Select.{id}";
            Slt_TorqueUnit.Location = new Point(179, 149);
            Slt_TorqueUnit.Name = "Slt_TorqueUnit";
            Slt_TorqueUnit.PlaceholderText = "无文本";
            Slt_TorqueUnit.SelectedIndex = 1;
            Slt_TorqueUnit.SelectedValue = "千分比";
            Slt_TorqueUnit.Size = new Size(91, 41);
            Slt_TorqueUnit.TabIndex = 17;
            Slt_TorqueUnit.Text = "千分比";
            // 
            // Slt_ForceUnit
            // 
            Slt_ForceUnit.AllowClear = true;
            Slt_ForceUnit.Items.AddRange(new object[] { "g", "Kg", "N" });
            Slt_ForceUnit.List = true;
            Slt_ForceUnit.LocalizationPlaceholderText = "Select.{id}";
            Slt_ForceUnit.Location = new Point(179, 201);
            Slt_ForceUnit.Name = "Slt_ForceUnit";
            Slt_ForceUnit.PlaceholderText = "无文本";
            Slt_ForceUnit.SelectedIndex = 0;
            Slt_ForceUnit.SelectedValue = "g";
            Slt_ForceUnit.Size = new Size(91, 41);
            Slt_ForceUnit.TabIndex = 18;
            Slt_ForceUnit.Text = "g";
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
            pageHeader_FrmMain.Size = new Size(413, 36);
            pageHeader_FrmMain.SubFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            pageHeader_FrmMain.SubText = "基本配置";
            pageHeader_FrmMain.TabIndex = 19;
            pageHeader_FrmMain.Text = "力控标定计算器";
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 403);
            Controls.Add(pageHeader_FrmMain);
            Controls.Add(Slt_ForceUnit);
            Controls.Add(Slt_TorqueUnit);
            Controls.Add(label3);
            Controls.Add(Cb_CailCurrent);
            Controls.Add(Slt_CurrentUnit);
            Controls.Add(Slt_ServoType);
            Controls.Add(Slt_DriveType);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_StartOutGuide);
            Controls.Add(Btn_StartGuide);
            EnableHitTest = false;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "力控标定计算器";
            Load += Frm_Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Button Btn_StartGuide;
        private AntdUI.Button Btn_StartOutGuide;
        private Label label1;
        private Label label2;
        private Label label4;
        private AntdUI.Select Slt_DriveType;
        private AntdUI.Select Slt_ServoType;
        private AntdUI.Select Slt_CurrentUnit;
        private AntdUI.Checkbox Cb_CailCurrent;
        private Label label3;
        private AntdUI.Select Slt_TorqueUnit;
        private AntdUI.Select Slt_ForceUnit;
        private AntdUI.PageHeader pageHeader_FrmMain;
    }
}
