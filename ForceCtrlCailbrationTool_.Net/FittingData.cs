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
        public static void FittingData_Method_1(List<double> independent, List<double> dependent, out ResultStruct result)
        {
            result = new ResultStruct()
            {
                FuncName = "最小二乘法",
                Slope = 0,
                Intercept = 0,
                Variance = 0,
            };

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

            result.Slope = Math.Round((independent.Count * sum_IndeMulDe - sumInde * sumDe) / (independent.Count * sum_SqInde - sumInde * sumInde), 5);
            result.Intercept = Math.Round((sumDe - result.Slope * sumInde) / independent.Count, 5);

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
        public static void FittingData_Method_2(List<double> independent, List<double> dependent, out ResultStruct result)
        {
            result = new ResultStruct()
            {
                FuncName = "一元一次方程",
                Slope = 0,
                Intercept = 0,
                Variance = 0,
            };

            if (independent.Count != dependent.Count || independent.Count < 2)
                return;

            result.Slope = Math.Round((dependent.Last() - dependent[0]) / (independent.Last() - independent[0]), 5);
            result.Intercept = Math.Round(dependent[0] - independent[0] * result.Slope, 3);

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
        public static void FittingData_Method_3(List<double> independent, List<double> dependent, out ResultStruct result)
        {
            result = new ResultStruct()
            {
                FuncName = "AI算法",
                Slope = 0,
                Intercept = 0,
                Variance = 0,
            };

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
            result.Slope = Math.Round(molecule / denominator, 5);
            result.Intercept = Math.Round(averDependent - averIndependent * result.Slope, 5);
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
        public delegate void DelegateFittingMethod(List<double> independent, List<double> dependent, out ResultStruct result);

        /// <summary>
        /// 现有拟合方法的集合
        /// </summary>
        public static readonly List<DelegateFittingMethod> ListFittingMethod = [FittingData_Method_1, FittingData_Method_2, FittingData_Method_3];


        /// <summary>
        /// 根据目标压力获取力矩限制
        /// 例：如果想要50g的压力，则应限制力矩为20％
        /// </summary>
        /// <param name="force">目标压力</param>
        /// <param name="result"></param>
        /// <returns>应限制力矩</returns>
        public static double GetTorque(double force, ResultStruct result) => (double)Math.Round((force - result.Intercept) / result.Slope, 4);

        /// <summary>
        /// 根据力矩限制推算理论压力
        /// 例：如果力矩限制为20％，则理论输出的压力为50g
        /// </summary>
        /// <param name="torque">当前力矩限制</param>
        /// <param name="result"></param>
        /// <returns>理论输出压力</returns>
        public static double GetForceWithTorque(double torque, ResultStruct result) => (double)Math.Round(torque * result.Slope + result.Intercept, 4);

        /// <summary>
        /// 根据当前电流换算理论压力
        /// 例：当前反馈电流200mA，换算理论输出压力为50g
        /// </summary>
        /// <param name="current">当前电流</param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static double GetForceWithCurrent(double current, ResultStruct result) => (double)Math.Round(current * result.Slope + result.Intercept, 4);

        /// <summary>
        /// 根据目标压力推算电流稳态值
        /// 例：想要在压力达到50g时停止，则应等待电流稳态在200mA
        /// </summary>
        /// <param name="force">目标压力</param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static double GetCurrent(double force, ResultStruct result) => (double)Math.Round((force - result.Intercept) / result.Slope, 4); 

    }
    public struct ResultStruct
    {
        /// <summary>
        /// 调用算法名称
        /// </summary>
        public string FuncName {  get; set; }

        /// <summary>
        /// 斜率（K）
        /// </summary>
        public double Slope {  get; set; }

        /// <summary>
        /// 截距（B)
        /// </summary>
        public double Intercept { get; set; }

        /// <summary>
        /// 方差（可信度）
        /// </summary>
        public double Variance { get; set; }
    }
}
