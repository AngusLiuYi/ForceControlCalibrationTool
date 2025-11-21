namespace ForceCtrlCailbrationTool_.Net_x._0_.frmUi
{
    partial class Frm_SaveFile
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
            Btn_Save = new AntdUI.Button();
            panel1 = new Panel();
            Pan_main = new AntdUI.Panel();
            FileNameInput = new AntdUI.Input();
            divider1 = new AntdUI.Divider();
            panel1.SuspendLayout();
            Pan_main.SuspendLayout();
            SuspendLayout();
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
            pageHeader_FrmBackupSelect.Size = new Size(380, 36);
            pageHeader_FrmBackupSelect.SubFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            pageHeader_FrmBackupSelect.SubText = "";
            pageHeader_FrmBackupSelect.TabIndex = 22;
            pageHeader_FrmBackupSelect.Text = "重命名文件";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft YaHei UI", 9F);
            label2.Location = new Point(0, 36);
            label2.Name = "label2";
            label2.Size = new Size(252, 85);
            label2.TabIndex = 23;
            label2.Text = "请输入备份名称\r\n通常我们建议您备份名称按如下模板\r\n“机台名称缩写+电机名称缩写+文件类型后缀”\r\n如：”贴标机_左1\"/\"AOI_上料2电缸\"\r\n或：“SN321A00”";
            // 
            // Btn_Save
            // 
            Btn_Save.AutoSizeMode = AntdUI.TAutoSize.Auto;
            Btn_Save.IconSvg = "SaveOutlined";
            Btn_Save.Location = new Point(145, 12);
            Btn_Save.Margin = new Padding(2, 3, 2, 3);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(87, 36);
            Btn_Save.TabIndex = 24;
            Btn_Save.Text = "确认保存";
            Btn_Save.Type = AntdUI.TTypeMini.Primary;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Btn_Save);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 351);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 60);
            panel1.TabIndex = 25;
            // 
            // Pan_main
            // 
            Pan_main.ArrowSize = 10;
            Pan_main.Controls.Add(FileNameInput);
            Pan_main.Controls.Add(divider1);
            Pan_main.Dock = DockStyle.Fill;
            Pan_main.Location = new Point(0, 121);
            Pan_main.Name = "Pan_main";
            Pan_main.Radius = 10;
            Pan_main.Shadow = 24;
            Pan_main.ShadowOpacity = 0.18F;
            Pan_main.ShadowOpacityAnimation = true;
            Pan_main.Size = new Size(380, 230);
            Pan_main.TabIndex = 26;
            // 
            // FileNameInput
            // 
            FileNameInput.LocalizationPlaceholderText = "Input.{id}";
            FileNameInput.Location = new Point(63, 90);
            FileNameInput.Margin = new Padding(2, 3, 2, 3);
            FileNameInput.Name = "FileNameInput";
            FileNameInput.PlaceholderText = "组装机_取料Z1";
            FileNameInput.PrefixText = "";
            FileNameInput.Size = new Size(240, 37);
            FileNameInput.SuffixText = ".csv";
            FileNameInput.TabIndex = 2;
            // 
            // divider1
            // 
            divider1.BackColor = Color.Transparent;
            divider1.Dock = DockStyle.Top;
            divider1.Location = new Point(24, 24);
            divider1.Margin = new Padding(10);
            divider1.Name = "divider1";
            divider1.Size = new Size(332, 1);
            divider1.TabIndex = 1;
            // 
            // Frm_SaveFile
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 411);
            Controls.Add(Pan_main);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pageHeader_FrmBackupSelect);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Frm_SaveFile";
            Resizable = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_SaveFile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Pan_main.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.PageHeader pageHeader_FrmBackupSelect;
        private Label label2;
        private AntdUI.Button Btn_Save;
        private Panel panel1;
        private AntdUI.Panel Pan_main;
        private AntdUI.Input FileNameInput;
        private AntdUI.Divider divider1;
    }
}