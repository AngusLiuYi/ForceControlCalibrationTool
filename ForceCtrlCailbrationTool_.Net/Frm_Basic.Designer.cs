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
            divider2 = new AntdUI.Divider();
            panel1.SuspendLayout();
            Pan_DataCheckout.SuspendLayout();
            SuspendLayout();
            // 
            // pageHeader_FrmBasic
            // 
            pageHeader_FrmBasic.Dock = DockStyle.Top;
            pageHeader_FrmBasic.Font = new Font("Microsoft YaHei UI", 12F);
            pageHeader_FrmBasic.Location = new Point(0, 0);
            pageHeader_FrmBasic.MaximizeBox = false;
            pageHeader_FrmBasic.Name = "pageHeader_FrmBasic";
            pageHeader_FrmBasic.Padding = new Padding(0, 0, 8, 0);
            pageHeader_FrmBasic.ShowButton = true;
            pageHeader_FrmBasic.Size = new Size(774, 36);
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
            panel1.Location = new Point(0, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 569);
            panel1.TabIndex = 21;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(0, 207);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(240, 362);
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
            Tb_DataInput.Name = "Tb_DataInput";
            Tb_DataInput.Radius = 6;
            Tb_DataInput.Size = new Size(240, 207);
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
            Tb_Result.EditMode = AntdUI.TEditMode.DoubleClick;
            Tb_Result.Gap = 12;
            Tb_Result.Location = new Point(240, 36);
            Tb_Result.Name = "Tb_Result";
            Tb_Result.Radius = 6;
            Tb_Result.Size = new Size(534, 189);
            Tb_Result.TabIndex = 4;
            // 
            // Pan_DataCheckout
            // 
            Pan_DataCheckout.ArrowSize = 10;
            Pan_DataCheckout.Controls.Add(divider2);
            Pan_DataCheckout.Dock = DockStyle.Fill;
            Pan_DataCheckout.Location = new Point(240, 225);
            Pan_DataCheckout.Name = "Pan_DataCheckout";
            Pan_DataCheckout.Radius = 10;
            Pan_DataCheckout.Shadow = 24;
            Pan_DataCheckout.ShadowOpacity = 0.18F;
            Pan_DataCheckout.ShadowOpacityAnimation = true;
            Pan_DataCheckout.Size = new Size(534, 380);
            Pan_DataCheckout.TabIndex = 26;
            // 
            // divider2
            // 
            divider2.BackColor = Color.Transparent;
            divider2.Dock = DockStyle.Top;
            divider2.Location = new Point(24, 24);
            divider2.Margin = new Padding(10);
            divider2.Name = "divider2";
            divider2.Size = new Size(486, 1);
            divider2.TabIndex = 1;
            divider2.Text = "测试拟合结果";
            // 
            // Frm_Basic
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 605);
            Controls.Add(Pan_DataCheckout);
            Controls.Add(Tb_Result);
            Controls.Add(panel1);
            Controls.Add(pageHeader_FrmBasic);
            Name = "Frm_Basic";
            Text = "Frm_Basic";
            Load += Frm_Basic_Load;
            Shown += Frm_Basic_Shown;
            panel1.ResumeLayout(false);
            Pan_DataCheckout.ResumeLayout(false);
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
    }
}