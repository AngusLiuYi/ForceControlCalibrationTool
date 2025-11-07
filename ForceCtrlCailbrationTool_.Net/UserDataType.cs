namespace ForceCtrlCailbrationTool_.Net_x._0_
{
    public static class UserDataType
    {
        /// <summary>
        /// config文件存放路径地址
        /// 完整显示：相对路径+文件名+类型后缀
        /// </summary>
        public static readonly string CfgFilePath = @"..\..\..\Data\Config.config";

        /// <summary>
        /// 标定数据备份路径地址
        /// 完整显示：相对路径
        /// </summary>
        public static readonly string CsvFilePath = @"..\..\..\Data\";

        /// <summary>
        /// 驱动器类型
        /// </summary>
        public enum DriveType
        {
            ISD大寰驱动器 = 0,
            SAC_NP1 = 1,
            SAC_NP2_轴一 = 1,
            SAC_NP2_轴二 = 2,
            SAC_NP4_轴一 = 1,
            SAC_NP4_轴二 = 2,
            SAC_NP4_轴三 = 3,
            SAC_NP4_轴四 = 4,
            一体式电爪 = 5,
            一体式电缸 = 6,
            SAC_N_电缸 = 6,
            SAC_S_电缸 = 6,
            SAC_NF_电缸_闭环力控 = 6,
        }

        /// <summary>
        /// 电机类型
        /// </summary>
        public enum ServoType
        {
            直驱_Dla_Dlar = 0,
            音圈_Vla_Vlar = 0,
            电缸_MCE_3G = 1,
            电缸_MCE_3WG = 1,
            电缸_MCE_4G = 1,
            电爪_PGEA = 2,
            电爪_PGIA = 2,
            电爪_PGHL_PGLS = 3,
        }

        public static List<object> GetNamesOfValue(Type enumType,int value)
        {
            List<object> listStr = [];
            string[] names = Enum.GetNames(enumType);
            foreach (string str in names)
            {
                if ((int)Enum.Parse(enumType,str) == value)
                    listStr.Add(str);
            }
            return listStr;
        }
    }
}
