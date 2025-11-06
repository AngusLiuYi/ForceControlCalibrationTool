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
            panel1 = new Panel();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            Tb_DataInput = new AntdUI.Table();
            Tb_Result = new AntdUI.Table();
            Pan_DataCheckout = new AntdUI.Panel();
            divider2 = new AntdUI.Divider();
            Btn_LoadFile = new AntdUI.Button();
            panel1.SuspendLayout();
            Pan_DataCheckout.SuspendLayout();
            SuspendLayout();
            // 
            // pageHeader_FrmMain
            // 
            pageHeader_FrmMain.Dock = DockStyle.Top;
            pageHeader_FrmMain.Font = new Font("Microsoft YaHei UI", 12F);
            pageHeader_FrmMain.Location = new Point(0, 0);
            pageHeader_FrmMain.Margin = new Padding(4);
            pageHeader_FrmMain.MaximizeBox = false;
            pageHeader_FrmMain.Name = "pageHeader_FrmMain";
            pageHeader_FrmMain.Padding = new Padding(0, 0, 10, 0);
            pageHeader_FrmMain.ShowButton = true;
            pageHeader_FrmMain.Size = new Size(990, 42);
            pageHeader_FrmMain.SubFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            pageHeader_FrmMain.SubText = "主界面";
            pageHeader_FrmMain.TabIndex = 20;
            pageHeader_FrmMain.Text = "力控标定计算器";
            // 
            // panel1
            // 
            panel1.Controls.Add(formsPlot1);
            panel1.Controls.Add(Tb_DataInput);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 42);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 663);
            panel1.TabIndex = 21;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(0, 244);
            formsPlot1.Margin = new Padding(4);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(309, 419);
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
            Tb_Result.EditMode = AntdUI.TEditMode.DoubleClick;
            Tb_Result.Gap = 12;
            Tb_Result.Location = new Point(309, 42);
            Tb_Result.Margin = new Padding(4);
            Tb_Result.Name = "Tb_Result";
            Tb_Result.Radius = 6;
            Tb_Result.Size = new Size(681, 169);
            Tb_Result.TabIndex = 4;
            // 
            // Pan_DataCheckout
            // 
            Pan_DataCheckout.ArrowSize = 10;
            Pan_DataCheckout.Controls.Add(divider2);
            Pan_DataCheckout.Controls.Add(Btn_LoadFile);
            Pan_DataCheckout.Dock = DockStyle.Fill;
            Pan_DataCheckout.Location = new Point(309, 211);
            Pan_DataCheckout.Margin = new Padding(4);
            Pan_DataCheckout.Name = "Pan_DataCheckout";
            Pan_DataCheckout.Radius = 10;
            Pan_DataCheckout.Shadow = 24;
            Pan_DataCheckout.ShadowOpacity = 0.18F;
            Pan_DataCheckout.ShadowOpacityAnimation = true;
            Pan_DataCheckout.Size = new Size(681, 494);
            Pan_DataCheckout.TabIndex = 26;
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
            // 
            // Btn_LoadFile
            // 
            Btn_LoadFile.AutoSizeMode = AntdUI.TAutoSize.Auto;
            Btn_LoadFile.IconSvg = "FolderOpenOutlined";
            Btn_LoadFile.Location = new Point(95, 99);
            Btn_LoadFile.Margin = new Padding(4);
            Btn_LoadFile.Name = "Btn_LoadFile";
            Btn_LoadFile.Size = new Size(109, 45);
            Btn_LoadFile.TabIndex = 22;
            Btn_LoadFile.Text = "加载备份";
            Btn_LoadFile.Type = AntdUI.TTypeMini.Primary;
            // 
            // Frm_Basic
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 705);
            Controls.Add(Pan_DataCheckout);
            Controls.Add(Tb_Result);
            Controls.Add(panel1);
            Controls.Add(pageHeader_FrmMain);
            Margin = new Padding(4);
            Name = "Frm_Basic";
            Text = "Frm_Basic";
            Load += Frm_Basic_Load;
            Shown += Frm_Basic_Shown;
            panel1.ResumeLayout(false);
            Pan_DataCheckout.ResumeLayout(false);
            Pan_DataCheckout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pageHeader_FrmMain;
        private Panel panel1;
        private AntdUI.Table Tb_DataInput;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private AntdUI.Table Tb_Result;
        private AntdUI.Panel Pan_DataCheckout;
        private AntdUI.Divider divider2;
        private AntdUI.Button Btn_LoadFile;
    }
}