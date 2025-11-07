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
        /// <param name="independent">自变量组（X值）</param>
        /// <param name="dependent">因变量组（Y值）</param>
        /// <param name="funcName">拟合算法名称</param>
        /// <param name="slope">斜率（K值）</param>
        /// <param name="intercept">截距（B值）</param>
        /// <param name="variance">方差</param>
        public static void FittingData_Method_1(List<double> independent, List<double> dependent, out string funcName, out double slope, out double intercept, out double variance)
        {
            funcName = "最小二乘法";
            intercept = 0.0;
            slope = 0.0;
            variance = 0.0;
            if (independent.Count != dependent.Count || independent.Count < 2)
                return;

            double sumInde = 0, sumDe = 0, sum_IndeMulDe = 0, sum_SqInde = 0;
            for (int i = 0; i < independent.Count; i++)
            {
                sumInde += independent[i];
                sumDe += dependent[i];
                sum_IndeMulDe += independent[i] * dependent[i];
                sum_SqInde += independent[i] * independent[i];
            }

            slope = Math.Round((independent.Count * sum_IndeMulDe - sumInde * sumDe) / (independent.Count * sum_SqInde - sumInde * sumInde), 5);
            intercept = Math.Round((sumDe - slope * sumInde) / independent.Count, 5);

            return;
        }

        /// <summary>
        /// 一元一次方程组拟合参数
        /// </summary>
        /// <param name="independent">自变量组（X值）</param>
        /// <param name="dependent">因变量组（Y值）</param>
        /// <param name="funcName">拟合算法名称</param>
        /// <param name="slope">斜率（K值）</param>
        /// <param name="intercept">截距（B值）</param>
        /// <param name="variance">方差</param>
        public static void FittingData_Method_2(List<double> independent, List<double> dependent, out string funcName, out double slope, out double intercept, out double variance)
        {
            funcName = "一元一次方程";
            intercept = 0.0;
            slope = 0.0;
            variance = 0.0;

            if (independent.Count != dependent.Count || independent.Count < 2)
                return;

            slope = Math.Round((dependent.Last() - dependent[0]) / (independent.Last() - independent[0]), 5);
            intercept = Math.Round(dependent[0] - independent[0] * slope, 3);

            return;
        }

        /// <summary>
        /// AI拟合参数
        /// </summary>
        /// <param name="independent">自变量组（X值）</param>
        /// <param name="dependent">因变量组（Y值）</param>
        /// <param name="funcName">拟合算法名称</param>
        /// <param name="slope">斜率（K值）</param>
        /// <param name="intercept">截距（B值）</param>
        /// <param name="variance">方差</param>
        public static void FittingData_Method_3(List<double> independent, List<double> dependent, out string funcName, out double slope, out double intercept, out double variance)
        {
            funcName = "AI生成";
            intercept = 0.0;
            slope = 0.0;
            variance = 0.0;

            if (independent.Count != dependent.Count || independent.Count < 2)
                return;
            double averIndependent = independent.Average();
            double averDependent = dependent.Average();
            double molecule = 0.0;
            double denominator = 0.0;
            for (int i = 0; i < independent.Count; i++)
            {
                molecule += (independent[i] - averIndependent) * (dependent[i] - averDependent);
                denominator += (independent[i] - averIndependent) * (independent[i] - averIndependent);
            }
            slope = Math.Round(molecule / denominator, 5);
            intercept = Math.Round(averDependent - averIndependent * slope, 5);
            return;
        }

        /// <summary>
        /// 拟合方法委托
        /// 用于加入集合，重复调用
        /// </summary>
        /// <param name="independent">自变量组（X值）</param>
        /// <param name="dependent">因变量组（Y值）</param>
        /// <param name="funcName">拟合算法名称</param>
        /// <param name="slope">斜率（K值）</param>
        /// <param name="intercept">截距（B值）</param>
        /// <param name="variance">方差</param>
        public delegate void DelegateFittingMethod(List<double> independent, List<double> dependent, out string funcName, out double slope, out double intercept, out double variance);

        /// <summary>
        /// 现有拟合方法的集合
        /// </summary>
        public static readonly List<DelegateFittingMethod> ListFittingMethod = [FittingData_Method_1, FittingData_Method_2, FittingData_Method_3];
    }
}
