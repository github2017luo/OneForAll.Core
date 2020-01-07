using System;

namespace OneForAll.Core.Utility
{
    /// <summary>
    /// 帮助类：日期时间
    /// </summary>
    public static class TimeHelper
    {

        #region 时间戳

        /// <summary>
        /// 转换当前时间的时间戳
        /// </summary>
        /// <returns>时间戳</returns>
        public static long ToTimeStamp()
        {
            return ToTimeStamp(DateTime.Now);
        }
        /// <summary>
        /// 转换指定时间为时间戳
        /// </summary>
        /// <param name="datetime">终止时间</param>
        /// <returns>时间戳</returns>
        public static long ToTimeStamp(DateTime datetime)
        {
            return new DateTimeOffset(datetime).ToUnixTimeSeconds();
        }
        /// <summary>
        /// 时间戳转为C#格式时间
        /// </summary>
        /// <param name="unix">时间戳</param>
        /// <returns>时间</returns>
        public static DateTime ToDateTime(long unix)
        {
            return DateTimeOffset.FromUnixTimeSeconds(unix).ToLocalTime().DateTime;
        }
        #endregion

        #region 中文格式时间
        /// <summary>
        /// 获取中文格式时间：yyyy年MM月dd日 星期x
        /// </summary>
        /// <param name="time">时间</param>
        /// <returns>星期x</returns>
        public static string ToChineseTimeWeek(DateTime datetime)
        {
            string time = string.Empty;
            DayOfWeek weekDay = datetime.DayOfWeek;
            var date = datetime.ToLongDateString();
                switch (weekDay)
            {
                case DayOfWeek.Sunday:
                    time = string.Format("{0} 星期{1}", datetime,"日");
                    break;
                case DayOfWeek.Monday:
                    time = string.Format("{0} 星期{1}", datetime, "一");
                    break;
                case DayOfWeek.Tuesday:
                    time = string.Format("{0} 星期{1}", datetime, "二");
                    break;
                case DayOfWeek.Wednesday:
                    time = string.Format("{0} 星期{1}", datetime, "三");
                    break;
                case DayOfWeek.Thursday:
                    time = string.Format("{0} 星期{1}", datetime, "四");
                    break;
                case DayOfWeek.Friday:
                    time = string.Format("{0} 星期{1}", datetime, "五");
                    break;
                case DayOfWeek.Saturday:
                    time = string.Format("{0} 星期{1}", datetime, "六");
                    break;
            }
            return time;
        }

        #endregion

    }
}
