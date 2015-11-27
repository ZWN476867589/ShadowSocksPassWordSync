using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShadowSocksPassWordSync
{
    public static class SystemHelper
    {
        public static Int64 GetTimeStamp()
        {
            TimeSpan ts = new TimeSpan();
            DateTime startTime = DateTime.Parse("1970/01/01 00:00:00");
            ts = DateTime.Now - startTime;
            return (Int64)ts.TotalMilliseconds;
        }
        public static Int64 GetTimeStampWithMillisecond()
        {
            TimeSpan ts = new TimeSpan();
            DateTime startTime = DateTime.Parse("1970/01/01 00:00:00");
            ts = DateTime.Now - startTime;
            Int64 seconds = Int64.Parse((Int64)ts.TotalSeconds + "" + DateTime.Now.Millisecond);
            return seconds;
        }
    }
}
