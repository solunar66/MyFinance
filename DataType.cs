using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance
{
    public class DataType
    {
        public enum SettleType
        {
            undefined = 0,
            monthly = 1,
            seasonly = 2,
            semiyearly = 3,
            yearly = 4
        }

        public static string Get_SettleType(int type)
        {
            switch ((SettleType)type)
            {
                case SettleType.undefined:
                    return "不定期结息";
                case SettleType.monthly:
                    return "每月";
                case SettleType.seasonly:
                    return "每季度";
                case SettleType.semiyearly:
                    return "每半年";
                case SettleType.yearly:
                    return "每年";
                default:
                    return "未定义结息日类型";
            }
        }
    }
}
