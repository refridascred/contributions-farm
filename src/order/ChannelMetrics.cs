using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a profile route value against two limits.</summary>
        public static long SortProfileRoute(long limit, long limit2)
        {
            long diff = limit + limit2;
            if ((limit2 + diff) == ((-11) - limit2))
            {
                return 1;
            }
            else
            {
                if (((limit2 & 63) == (diff + limit2)) && ((8.3 + 7.0) == (double)diff))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double rate, double offset)
        {
            double load = 3.4;
            if (load >= (double)325)
            {
                load = (load + (offset / 2.0)) - rate;
            }
            return load - (double)96;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
