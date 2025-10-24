namespace A20231109
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BtnFitting = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.btnIns = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPressure = new System.Windows.Forms.TextBox();
            this.btnDelet = new System.Windows.Forms.Button();
            this.FitResult1 = new System.Windows.Forms.Label();
            this.FitResult2 = new System.Windows.Forms.Label();
            this.FitResult3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbRatedCurrent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFitting
            // 
            this.BtnFitting.Location = new System.Drawing.Point(230, 114);
            this.BtnFitting.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFitting.Name = "BtnFitting";
            this.BtnFitting.Size = new System.Drawing.Size(92, 29);
            this.BtnFitting.TabIndex = 0;
            this.BtnFitting.Text = "拟合数据";
            this.BtnFitting.UseVisualStyleBackColor = true;
            this.BtnFitting.Click += new System.EventHandler(this.BtnFitting_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(9, 156);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(237, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "序号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column2.FillWeight = 40F;
            this.Column2.HeaderText = "电流";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column3.FillWeight = 40F;
            this.Column3.HeaderText = "压力";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(260, 156);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.ShadowOffset = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Lime;
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Blue;
            series7.Legend = "Legend1";
            series7.Name = "Series3";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.MediumOrchid;
            series8.Legend = "Legend1";
            series8.Name = "Series4";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(327, 255);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(126, 44);
            this.tbCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(71, 21);
            this.tbCurrent.TabIndex = 1;
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(9, 114);
            this.btnIns.Margin = new System.Windows.Forms.Padding(2);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(92, 29);
            this.btnIns.TabIndex = 3;
            this.btnIns.Text = "添加数据";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "限定电流(额定%)：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "实际压力值(g)：";
            // 
            // tbPressure
            // 
            this.tbPressure.Location = new System.Drawing.Point(126, 76);
            this.tbPressure.Margin = new System.Windows.Forms.Padding(2);
            this.tbPressure.Name = "tbPressure";
            this.tbPressure.Size = new System.Drawing.Size(71, 21);
            this.tbPressure.TabIndex = 2;
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(112, 114);
            this.btnDelet.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(92, 29);
            this.btnDelet.TabIndex = 0;
            this.btnDelet.Text = "删除数据";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // FitResult1
            // 
            this.FitResult1.AutoSize = true;
            this.FitResult1.BackColor = System.Drawing.Color.Transparent;
            this.FitResult1.ForeColor = System.Drawing.Color.Lime;
            this.FitResult1.Location = new System.Drawing.Point(355, 94);
            this.FitResult1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FitResult1.Name = "FitResult1";
            this.FitResult1.Size = new System.Drawing.Size(95, 12);
            this.FitResult1.TabIndex = 0;
            this.FitResult1.Text = "F = k1 * I + b1";
            // 
            // FitResult2
            // 
            this.FitResult2.AutoSize = true;
            this.FitResult2.BackColor = System.Drawing.Color.Transparent;
            this.FitResult2.ForeColor = System.Drawing.Color.Blue;
            this.FitResult2.Location = new System.Drawing.Point(355, 114);
            this.FitResult2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FitResult2.Name = "FitResult2";
            this.FitResult2.Size = new System.Drawing.Size(95, 12);
            this.FitResult2.TabIndex = 0;
            this.FitResult2.Text = "F = k2 * I + b2";
            // 
            // FitResult3
            // 
            this.FitResult3.AutoSize = true;
            this.FitResult3.BackColor = System.Drawing.Color.Transparent;
            this.FitResult3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.FitResult3.Location = new System.Drawing.Point(355, 131);
            this.FitResult3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FitResult3.Name = "FitResult3";
            this.FitResult3.Size = new System.Drawing.Size(95, 12);
            this.FitResult3.TabIndex = 0;
            this.FitResult3.Text = "F = k3 * I + b3";
            this.FitResult3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "如果需要";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "g的力，则应限定为额定电流的0.%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "230A反馈";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "mA,则代表当前实际压力值为(g)0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(309, 34);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 21);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "‰ 则代表当前实际压力值为(g)0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "6078反馈";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(309, 61);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 21);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "电机额定电流(mA)：";
            // 
            // TbRatedCurrent
            // 
            this.TbRatedCurrent.Location = new System.Drawing.Point(126, 14);
            this.TbRatedCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.TbRatedCurrent.Name = "TbRatedCurrent";
            this.TbRatedCurrent.Size = new System.Drawing.Size(71, 21);
            this.TbRatedCurrent.TabIndex = 0;
            this.TbRatedCurrent.Text = "1000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 422);
            this.Controls.Add(this.TbRatedCurrent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FitResult3);
            this.Controls.Add(this.FitResult2);
            this.Controls.Add(this.FitResult1);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.tbPressure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnFitting);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "DH 力控标定 v1.1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFitting;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPressure;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Label FitResult1;
        private System.Windows.Forms.Label FitResult2;
        private System.Windows.Forms.Label FitResult3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbRatedCurrent;
    }
}

