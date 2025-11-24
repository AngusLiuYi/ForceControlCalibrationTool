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
            pageHeader_FrmBasic = new AntdUI.PageHeader();
            panel1 = new Panel();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            Tb_DataInput = new AntdUI.Table();
            Tb_Result = new AntdUI.Table();
            Pan_DataCheckout = new AntdUI.Panel();
            Pan_CurrentCheckout = new Panel();
            panel6 = new Panel();
            Lb_Force2 = new AntdUI.Input();
            label5 = new Label();
            Lb_TarCurrent1 = new AntdUI.Input();
            panel5 = new Panel();
            Lb_Current1 = new AntdUI.Input();
            label4 = new Label();
            Lb_TarForce2 = new AntdUI.Input();
            panel4 = new Panel();
            Lb_Force1 = new AntdUI.Input();
            label3 = new Label();
            Lb_TarTorque1 = new AntdUI.Input();
            panel2 = new Panel();
            Lb_Torque1 = new AntdUI.Input();
            label2 = new Label();
            Lb_TarForce1 = new AntdUI.Input();
            panel3 = new Panel();
            Slt_MethodChange = new AntdUI.Select();
            label1 = new Label();
            divider2 = new AntdUI.Divider();
            panel1.SuspendLayout();
            Pan_DataCheckout.SuspendLayout();
            Pan_CurrentCheckout.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pageHeader_FrmBasic
            // 
            pageHeader_FrmBasic.Dock = DockStyle.Top;
            pageHeader_FrmBasic.Font = new Font("Microsoft YaHei UI", 12F);
            pageHeader_FrmBasic.Location = new Point(0, 0);
            pageHeader_FrmBasic.Margin = new Padding(4);
            pageHeader_FrmBasic.MaximizeBox = false;
            pageHeader_FrmBasic.Name = "pageHeader_FrmBasic";
            pageHeader_FrmBasic.Padding = new Padding(0, 0, 10, 0);
            pageHeader_FrmBasic.ShowButton = true;
            pageHeader_FrmBasic.Size = new Size(990, 42);
            pageHeader_FrmBasic.SubFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            pageHeader_FrmBasic.SubText = "主界面";
            pageHeader_FrmBasic.TabIndex = 20;
            pageHeader_FrmBasic.Text = "力控标定计算器";
            // 
            // panel1
            // 
            panel1.Controls.Add(formsPlot1);
            panel1.Controls.Add(Tb_DataInput);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 42);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 661);
            panel1.TabIndex = 21;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(0, 244);
            formsPlot1.Margin = new Padding(4);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(309, 417);
            formsPlot1.TabIndex = 4;
            // 
            // Tb_DataInput
            // 
            Tb_DataInput.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            Tb_DataInput.BorderCellWidth = 3F;
            Tb_DataInput.Bordered = true;
            Tb_DataInput.BorderWidth = 3F;
            Tb_DataInput.CellImpactHeight = false;
            Tb_DataInput.Dock = DockStyle.Top;
            Tb_DataInput.EditInputStyle = AntdUI.TEditInputStyle.Excel;
            Tb_DataInput.EditMode = AntdUI.TEditMode.DoubleClick;
            Tb_DataInput.EditSelection = AntdUI.TEditSelection.All;
            Tb_DataInput.Gap = 12;
            Tb_DataInput.Location = new Point(0, 0);
            Tb_DataInput.Margin = new Padding(4);
            Tb_DataInput.Name = "Tb_DataInput";
            Tb_DataInput.Radius = 6;
            Tb_DataInput.Size = new Size(309, 244);
            Tb_DataInput.TabIndex = 3;
            Tb_DataInput.MouseDown += Tb_DataInput_MouseDown;
            // 
            // Tb_Result
            // 
            Tb_Result.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            Tb_Result.BorderCellWidth = 3F;
            Tb_Result.Bordered = true;
            Tb_Result.BorderWidth = 3F;
            Tb_Result.CellImpactHeight = false;
            Tb_Result.Dock = DockStyle.Top;
            Tb_Result.Gap = 12;
            Tb_Result.Location = new Point(309, 42);
            Tb_Result.Margin = new Padding(4);
            Tb_Result.Name = "Tb_Result";
            Tb_Result.Radius = 6;
            Tb_Result.Size = new Size(681, 222);
            Tb_Result.TabIndex = 4;
            // 
            // Pan_DataCheckout
            // 
            Pan_DataCheckout.ArrowSize = 10;
            Pan_DataCheckout.Controls.Add(Pan_CurrentCheckout);
            Pan_DataCheckout.Controls.Add(panel4);
            Pan_DataCheckout.Controls.Add(panel2);
            Pan_DataCheckout.Controls.Add(panel3);
            Pan_DataCheckout.Controls.Add(divider2);
            Pan_DataCheckout.Dock = DockStyle.Fill;
            Pan_DataCheckout.Enabled = false;
            Pan_DataCheckout.Location = new Point(309, 264);
            Pan_DataCheckout.Margin = new Padding(4);
            Pan_DataCheckout.Name = "Pan_DataCheckout";
            Pan_DataCheckout.Radius = 10;
            Pan_DataCheckout.Shadow = 24;
            Pan_DataCheckout.ShadowOpacity = 0.18F;
            Pan_DataCheckout.ShadowOpacityAnimation = true;
            Pan_DataCheckout.Size = new Size(681, 439);
            Pan_DataCheckout.TabIndex = 26;
            Pan_DataCheckout.EnabledChanged += Pan_DataCheckout_EnabledChanged;
            // 
            // Pan_CurrentCheckout
            // 
            Pan_CurrentCheckout.BackColor = Color.Transparent;
            Pan_CurrentCheckout.Controls.Add(panel6);
            Pan_CurrentCheckout.Controls.Add(panel5);
            Pan_CurrentCheckout.Dock = DockStyle.Top;
            Pan_CurrentCheckout.Location = new Point(30, 180);
            Pan_CurrentCheckout.Name = "Pan_CurrentCheckout";
            Pan_CurrentCheckout.Size = new Size(621, 115);
            Pan_CurrentCheckout.TabIndex = 15;
            Pan_CurrentCheckout.Visible = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(Lb_Force2);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(Lb_TarCurrent1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 49);
            panel6.Name = "panel6";
            panel6.Size = new Size(621, 49);
            panel6.TabIndex = 16;
            // 
            // Lb_Force2
            // 
            Lb_Force2.Dock = DockStyle.Fill;
            Lb_Force2.Font = new Font("Microsoft YaHei UI", 10F);
            Lb_Force2.JoinMode = AntdUI.TJoinMode.Right;
            Lb_Force2.LocalizationPlaceholderText = "Input.{id}";
            Lb_Force2.Location = new Point(476, 0);
            Lb_Force2.Name = "Lb_Force2";
            Lb_Force2.PlaceholderText = "无结果";
            Lb_Force2.PrefixText = "";
            Lb_Force2.ReadOnly = true;
            Lb_Force2.Size = new Size(145, 49);
            Lb_Force2.SuffixText = "Unit";
            Lb_Force2.TabIndex = 13;
            Lb_Force2.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Microsoft YaHei UI", 10F);
            label5.Location = new Point(269, 0);
            label5.Margin = new Padding(4, 3, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(207, 49);
            label5.TabIndex = 12;
            label5.Text = "则理论输出压力";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lb_TarCurrent1
            // 
            Lb_TarCurrent1.Dock = DockStyle.Left;
            Lb_TarCurrent1.Font = new Font("Microsoft YaHei UI", 10F);
            Lb_TarCurrent1.JoinMode = AntdUI.TJoinMode.Left;
            Lb_TarCurrent1.LocalizationPlaceholderText = "Input.{id}";
            Lb_TarCurrent1.Location = new Point(0, 0);
            Lb_TarCurrent1.Name = "Lb_TarCurrent1";
            Lb_TarCurrent1.PlaceholderText = "500";
            Lb_TarCurrent1.PrefixText = "如电流反馈";
            Lb_TarCurrent1.Size = new Size(269, 49);
            Lb_TarCurrent1.SuffixText = "mA";
            Lb_TarCurrent1.TabIndex = 11;
            Lb_TarCurrent1.TextAlign = HorizontalAlignment.Center;
            Lb_TarCurrent1.TextChanged += Lb_TarForce1_TextChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(Lb_Current1);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(Lb_TarForce2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(621, 49);
            panel5.TabIndex = 15;
            // 
            // Lb_Current1
            // 
            Lb_Current1.Dock = DockStyle.Fill;
            Lb_Current1.Font = new Font("Microsoft YaHei UI", 10F);
            Lb_Current1.JoinMode = AntdUI.TJoinMode.Right;
            Lb_Current1.LocalizationPlaceholderText = "Input.{id}";
            Lb_Current1.Location = new Point(380, 0);
            Lb_Current1.Name = "Lb_Current1";
            Lb_Current1.PlaceholderText = "无结果";
            Lb_Current1.PrefixText = "0x000";
            Lb_Current1.ReadOnly = true;
            Lb_Current1.Size = new Size(241, 49);
            Lb_Current1.SuffixText = "mA";
            Lb_Current1.TabIndex = 13;
            Lb_Current1.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Microsoft YaHei UI", 10F);
            label4.Location = new Point(196, 0);
            label4.Margin = new Padding(4, 3, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(184, 49);
            label4.TabIndex = 12;
            label4.Text = "则电流稳态值";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lb_TarForce2
            // 
            Lb_TarForce2.Dock = DockStyle.Left;
            Lb_TarForce2.Font = new Font("Microsoft YaHei UI", 10F);
            Lb_TarForce2.JoinMode = AntdUI.TJoinMode.Left;
            Lb_TarForce2.LocalizationPlaceholderText = "Input.{id}";
            Lb_TarForce2.Location = new Point(0, 0);
            Lb_TarForce2.Name = "Lb_TarForce2";
            Lb_TarForce2.PlaceholderText = "500";
            Lb_TarForce2.PrefixText = "目标压力";
            Lb_TarForce2.Size = new Size(196, 49);
            Lb_TarForce2.SuffixText = "Unit";
            Lb_TarForce2.TabIndex = 11;
            Lb_TarForce2.TextAlign = HorizontalAlignment.Center;
            Lb_TarForce2.TextChanged += Lb_TarForce1_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(Lb_Force1);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(Lb_TarTorque1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(30, 131);
            panel4.Name = "panel4";
            panel4.Size = new Size(621, 49);
            panel4.TabIndex = 14;
            // 
            // Lb_Force1
            // 
            Lb_Force1.Dock = DockStyle.Fill;
            Lb_Force1.Font = new Font("Microsoft YaHei UI", 10F);
            Lb_Force1.JoinMode = AntdUI.TJoinMode.Right;
            Lb_Force1.LocalizationPlaceholderText = "Input.{id}";
            Lb_Force1.Location = new Point(476, 0);
            Lb_Force1.Name = "Lb_Force1";
            Lb_Force1.PlaceholderText = "无结果";
            Lb_Force1.PrefixText = "";
            Lb_Force1.ReadOnly = true;
            Lb_Force1.Size = new Size(145, 49);
            Lb_Force1.SuffixText = "Unit";
            Lb_Force1.TabIndex = 13;
            Lb_Force1.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Microsoft YaHei UI", 10F);
            label3.Location = new Point(269, 0);
            label3.Margin = new Padding(4, 3, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(207, 49);
            label3.TabIndex = 12;
            label3.Text = "则理论输出压力";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lb_TarTorque1
            // 
            Lb_TarTorque1.Dock = DockStyle.Left;
            Lb_TarTorque1.Font = new Font("Microsoft YaHei UI", 10F);
            Lb_TarTorque1.JoinMode = AntdUI.TJoinMode.Left;
            Lb_TarTorque1.LocalizationPlaceholderText = "Input.{id}";
            Lb_TarTorque1.Location = new Point(0, 0);
            Lb_TarTorque1.Name = "Lb_TarTorque1";
            Lb_TarTorque1.PlaceholderText = "500";
            Lb_TarTorque1.PrefixText = "如设力矩限制";
            Lb_TarTorque1.Size = new Size(269, 49);
            Lb_TarTorque1.SuffixText = "‰";
            Lb_TarTorque1.TabIndex = 11;
            Lb_TarTorque1.TextAlign = HorizontalAlignment.Center;
            Lb_TarTorque1.TextChanged += Lb_TarForce1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(Lb_Torque1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Lb_TarForce1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(30, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(621, 49);
            panel2.TabIndex = 13;
            // 
            // Lb_Torque1
            // 
            Lb_Torque1.Dock = DockStyle.Fill;
            Lb_Torque1.Font = new Font("Microsoft YaHei UI", 10F);
            Lb_Torque1.JoinMode = AntdUI.TJoinMode.Right;
            Lb_Torque1.LocalizationPlaceholderText = "Input.{id}";
            Lb_Torque1.Location = new Point(380, 0);
            Lb_Torque1.Name = "Lb_Torque1";
            Lb_Torque1.PlaceholderText = "无结果";
            Lb_Torque1.PrefixText = "0x0000";
            Lb_Torque1.ReadOnly = true;
            Lb_Torque1.Size = new Size(241, 49);
            Lb_Torque1.SuffixText = "‰";
            Lb_Torque1.TabIndex = 13;
            Lb_Torque1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Microsoft YaHei UI", 10F);
            label2.Location = new Point(196, 0);
            label2.Margin = new Padding(4, 3, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 49);
            label2.TabIndex = 12;
            label2.Text = "则设置力控限制地址";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lb_TarForce1
            // 
            Lb_TarForce1.Dock = DockStyle.Left;
            Lb_TarForce1.Font = new Font("Microsoft YaHei UI", 10F);
            Lb_TarForce1.JoinMode = AntdUI.TJoinMode.Left;
            Lb_TarForce1.LocalizationPlaceholderText = "Input.{id}";
            Lb_TarForce1.Location = new Point(0, 0);
            Lb_TarForce1.Name = "Lb_TarForce1";
            Lb_TarForce1.PlaceholderText = "500";
            Lb_TarForce1.PrefixText = "目标压力";
            Lb_TarForce1.Size = new Size(196, 49);
            Lb_TarForce1.SuffixText = "Unit";
            Lb_TarForce1.TabIndex = 11;
            Lb_TarForce1.TextAlign = HorizontalAlignment.Center;
            Lb_TarForce1.TextChanged += Lb_TarForce1_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(Slt_MethodChange);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(30, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(621, 51);
            panel3.TabIndex = 12;
            // 
            // Slt_MethodChange
            // 
            Slt_MethodChange.AllowClear = true;
            Slt_MethodChange.Dock = DockStyle.Right;
            Slt_MethodChange.List = true;
            Slt_MethodChange.LocalizationPlaceholderText = "Select.{id}";
            Slt_MethodChange.Location = new Point(374, 0);
            Slt_MethodChange.Margin = new Padding(4);
            Slt_MethodChange.Name = "Slt_MethodChange";
            Slt_MethodChange.PlaceholderText = "无文本";
            Slt_MethodChange.Size = new Size(247, 51);
            Slt_MethodChange.TabIndex = 18;
            Slt_MethodChange.Text = "未选择算法";
            Slt_MethodChange.SelectedIndexChanged += Slt_MethodChange_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Microsoft YaHei UI", 16F);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 51);
            label1.TabIndex = 9;
            label1.Text = "数据校验";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divider2
            // 
            divider2.BackColor = Color.Transparent;
            divider2.Dock = DockStyle.Top;
            divider2.Location = new Point(30, 30);
            divider2.Margin = new Padding(13, 12, 13, 12);
            divider2.Name = "divider2";
            divider2.Size = new Size(621, 1);
            divider2.TabIndex = 1;
            divider2.Text = "测试拟合结果";
            // 
            // Frm_Basic
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 703);
            Controls.Add(Pan_DataCheckout);
            Controls.Add(Tb_Result);
            Controls.Add(panel1);
            Controls.Add(pageHeader_FrmBasic);
            Margin = new Padding(4);
            Name = "Frm_Basic";
            Text = "Frm_Basic";
            Load += Frm_Basic_Load;
            Shown += Frm_Basic_Shown;
            panel1.ResumeLayout(false);
            Pan_DataCheckout.ResumeLayout(false);
            Pan_CurrentCheckout.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pageHeader_FrmBasic;
        private Panel panel1;
        private AntdUI.Table Tb_DataInput;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private AntdUI.Table Tb_Result;
        private AntdUI.Panel Pan_DataCheckout;
        private AntdUI.Divider divider2;
        private Label label1;
        private Panel panel2;
        private AntdUI.Input Lb_Torque1;
        private Label label2;
        private AntdUI.Input Lb_TarForce1;
        private Panel panel3;
        private AntdUI.Select Slt_MethodChange;
        private Panel panel4;
        private AntdUI.Input Lb_Force1;
        private Label label3;
        private AntdUI.Input Lb_TarTorque1;
        private Panel Pan_CurrentCheckout;
        private Panel panel6;
        private AntdUI.Input Lb_Force2;
        private Label label5;
        private AntdUI.Input Lb_TarCurrent1;
        private Panel panel5;
        private AntdUI.Input Lb_Current1;
        private Label label4;
        private AntdUI.Input Lb_TarForce2;
    }
}