using ScottPlot.ArrowShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForceCtrlCailbrationTool_.Net_x._0_
{
    public static class FittingData
    {
        /// <summary>
        /// 最小二乘法拟合参数
        /// </summary>
        /// <param name="torqueSetting">力矩限制数据列表</param>
        /// <param name="forceValue">实际输出压力数据列表</param>
        /// <param name="slope">斜率（K值）</param>
        /// <param name="intercept">截距（B值）</param>
        /// <param name="variance">方差</param>
        public static void FittingData_Method_1(List<double> torqueSetting, List<double> forceValue, out double slope, out double intercept, out double variance)
        {
            intercept = 0.0;
            slope = 0.0;
            variance = 0.0;
            if (torqueSetting.Count != forceValue.Count || torqueSetting.Count < 2)
                return;
            double sumX = 0, sumY = 0, sumXY = 0, sumXX = 0;
            for (int i = 0; i < torqueSetting.Count; i++)
            {
                sumX += torqueSetting[i];
                sumY += forceValue[i];
                sumXY += torqueSetting[i] * forceValue[i];
                sumXX += torqueSetting[i] * torqueSetting[i];
            }
            slope = Math.Round((torqueSetting.Count * sumXY - sumX * sumY) / (torqueSetting.Count * sumXX - sumX * sumX), 5);
            intercept = Math.Round((sumY - slope * sumX) / torqueSetting.Count, 5);

            return;
        }
    }
}
