using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace A20231109
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 拟合算法1
        /// 无锡客户在用算法
        /// </summary>
        /// <param name="listCurrent">限定电流的值</param>
        /// <param name="listPressure">实际压测值</param>
        /// <param name="doubleK">斜率k</param>
        /// <param name="doubleB">截距b</param>
        public static void Fitting_1(List<double> listCurrent, List<double> listPressure, out double doubleK, out double doubleB)
        {
            doubleB = 0.0;
            doubleK = 0.0;
            if (listCurrent.Count == listPressure.Count && listCurrent.Count >= 2)
            {
                double averX = listCurrent.Average();
                double averY = listPressure.Average();
                double molecule = 0.0;
                double denominator = 0.0;
                for (int i = 0; i < listCurrent.Count; i++)
                {
                    molecule += (listCurrent[i] - averX) * (listPressure[i] - averY);
                    denominator += (listCurrent[i] - averX) * (listCurrent[i] - averX);
                }
                doubleK = Math.Round(molecule / denominator, 5);
                doubleB = Math.Round(averY - averX * doubleK, 5);
            }
            return;
        }

        /// <summary>
        /// 拟合算法2
        /// 常规算法/最大值与最小值参与计算。非线性时存在一定偏差
        /// </summary>
        /// <param name="listCurrent">限定电流的值</param>
        /// <param name="listPressure">实际压测值</param>
        /// <param name="doubleK">斜率k</param>
        /// <param name="doubleB">截距b</param>
        public static void Fitting_2(List<double>listCurrent, List<double> listPressure,out double doubleK,out double doubleB)
        {
            doubleB = 0.0;
            doubleK = 0.0;
            if (listCurrent.Count == listPressure.Count && listCurrent.Count >= 2)
            {
                doubleK = Math.Round((listPressure.Last() - listPressure[0]) / (listCurrent.Last() - listCurrent[0]), 5);
                doubleB = Math.Round(listPressure[0] - listCurrent[0] * doubleK, 3);
            }
            return;
        }

        /// <summary>
        /// 拟合算法3
        /// 最小二乘法/所有数据参与计算。目前最优算法
        /// </summary>
        /// <param name="listCurrent">限定电流的值</param>
        /// <param name="listPressure">实际压测值</param>
        /// <param name="doubleK">斜率k</param>
        /// <param name="doubleB">截距b</param>
        public static void Fitting_3(List<double> listCurrent, List<double> listPressure, out double doubleK, out double doubleB)
        {
            doubleB = 0.0;
            doubleK = 0.0;
            if (listCurrent.Count == listPressure.Count && listCurrent.Count >= 2)
            {
                double sumX = 0, sumY = 0, sumXY = 0, sumXX = 0;
                for (int i = 0; i < listCurrent.Count; i++)
                {
                    sumX += listCurrent[i];
                    sumY += listPressure[i];
                    sumXY += listCurrent[i] * listPressure[i];
                    sumXX += listCurrent[i] * listCurrent[i];
                }
                doubleK = Math.Round((listCurrent.Count * sumXY - sumX * sumY) / (listCurrent.Count * sumXX - sumX * sumX), 5);
                doubleB = Math.Round((sumY - doubleK * sumX) / listCurrent.Count, 5);
            }
            return;
        }

        /// <summary>
        /// 添加数据组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIns_Click(object sender, EventArgs e)
        {
            //电流输入：额定电流的百分比
            //实际压力输入：传感器读取实际值，单位：g
            if (tbCurrent.Text != "" && tbPressure.Text != "")
            {
                dataGridView1.Rows.Add(new object[] { dataGridView1.Rows.Count + 1, tbCurrent.Text, tbPressure.Text });
                DataGridViewsRefresh(out _, out _);
            }
        }

        /// <summary>
        /// 删除选定数据组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                DataGridViewsRefresh(out _, out _);
            }
        }

        /// <summary>
        /// 将表格数据输出List类型，并刷新Chart图表
        /// </summary>
        /// <param name="listCurrent">输出电流表单</param>
        /// <param name="listPressure">输出实际压力表单</param>
        private void DataGridViewsRefresh(out List<double> listCurrent,out List<double> listPressure)
        {
            listCurrent = new List<double>();
            listPressure = new List<double>();

            if (dataGridView1.Rows.Count > 0)
            {
                //按行读取表格，并将值依次赋给list表单
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    listCurrent.Add(Convert.ToDouble(row.Cells[1].Value));
                    listPressure.Add(Convert.ToDouble(row.Cells[2].Value));
                }
                //升序排列
                listCurrent.Sort();
                listPressure.Sort();

                //表单数据重新赋值整理
                dataGridView1.Rows.Clear();
                for (int i = 0; i < listCurrent.Count; i++)
                {
                    dataGridView1.Rows.Add(new object[] { i + 1, listCurrent[i], listPressure[i] });
                }

                //向图表添加点位
                chart1.Series[0].Points.DataBindXY(listCurrent, listPressure);
            }
            return;
        }

        /// <summary>
        /// 调用拟合算法，生成k、b值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFitting_Click(object sender, EventArgs e)
        {
            //获得现有数据组
            DataGridViewsRefresh(out List<double> listCurrent, out List<double> listPressure);
            if(listCurrent.Count >= 2)
            {
                //依次调用拟合算法，输出k、b值
                Fitting_1(listCurrent, listPressure, out double k1, out double b1);
                FitResult1.Text="F = "+k1.ToString()+" * I + "+b1.ToString();
                Fitting_2(listCurrent,listPressure, out double k2, out double b2);
                FitResult2.Text = "F = " + k2.ToString() + " * I + " + b2.ToString();
                Fitting_3(listCurrent, listPressure, out double k3, out double b3);
                FitResult3.Text = "F = " + k3.ToString() + " * I + " + b3.ToString();

                //将求得斜率、截距输出到图表上比较优劣
                chart1.Series[1].Points.Clear();
                //chart1.Series[1].Points.AddXY(listCurrent[0], listCurrent[0] * k1 + b1);
                //chart1.Series[1].Points.AddXY(listCurrent.Last(), listCurrent.Last() * k1 + b1);

                chart1.Series[2].Points.Clear();
                chart1.Series[2].Points.AddXY(listCurrent[0], (listCurrent[0]) * k2 + b2);
                chart1.Series[2].Points.AddXY(listCurrent.Last(), listCurrent.Last() * k2 + b2);

                chart1.Series[3].Points.Clear();
                chart1.Series[3].Points.AddXY(listCurrent[0], listCurrent[0] * k3 + b3);
                chart1.Series[3].Points.AddXY(listCurrent.Last(), listCurrent.Last() * k3 + b3);

                Slope = k3;
                Intercept = b3;
            }
        }

        private double Slope = 1, Intercept = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //0x60E0:
            //大寰驱动限定电流寄存器，万分比
            //行动元驱动器，千分比
            //高创驱动器，千分比
            //此处单位：统一百分比
            //根据 F = K * I + B 反推
            //想要获得n克的压力，则0x60E0限制的值应该为 I = ( F - B ) / K
            double pressure = 0;
            try
            {
                pressure = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            { }
            double x60E0 = Math.Round((pressure - Intercept) / Slope, 4);
            label4.Text = "g的力，则应限定为额定电流的" + x60E0.ToString() + " %";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //0x230A反馈为实际电流值
            //参与计算的是额定电流百分比
            //所以要进行一遍转换！！！！！
            double pressure = 0;
            //取额定电流1200mA计算
            try
            {
                double ratedCurrent = Convert.ToDouble(TbRatedCurrent.Text);
                double x230A =Convert.ToDouble(textBox2.Text);
                pressure = (x230A / ratedCurrent) * 100 * Slope + Intercept;
            }
            catch (Exception)
            { }
            label6.Text = "mA,则代表当前实际压力值为(g)" + pressure.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //0x6078反馈为额定电流千分比
            //参与计算同样要先转换！！！！！
            //
            double pressure = 0;
            try
            {
                double x6078 = Convert.ToDouble(textBox3.Text);
                pressure = (x6078 / 10) * Slope + Intercept;
            }
            catch (Exception)
            { }
            label7.Text = "‰ 则代表当前实际压力值为(g)" + pressure.ToString();

        }

    }
}
