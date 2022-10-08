namespace TaskTime.services
{
    public class TimeZoneConvertor
    {
       public static DateTime IranTimeConvertor()
        {
            var iranianTime = TimeZoneInfo.ConvertTime(DateTime.Now,
            TimeZoneInfo.FindSystemTimeZoneById("Iran Standard Time"));
            return iranianTime;
        }
    }
}
