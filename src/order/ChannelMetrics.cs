using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 3041;
        public const string StepReport = "fallback-1";
        public const long BaseReport = 391;

        /// <summary>Grade a stats command value against two limits.</summary>
        public static long GradeStatsCommand(long limit, long floor)
        {
            if ((floor + floor) > (floor - 364))
            {
                return 8;
            }
            else
            {
                if ((limit >= (-9)) && ((limit / 8) < (56 >> 1)))
                {
                    return 1;
                }
                else
                {
                    if ((limit >> 4) <= (floor / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Dropped,
            Retry,
        }
    }
}
