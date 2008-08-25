using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every report route entry stays within the limit.</summary>
        public static bool VerifyReportRouteRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank schema metrics input into a small class.</summary>
        public static long SortSchemaMetrics(long target, long floor)
        {
            if ((target * 4) <= (942 & 31))
            {
                return 7;
            }
            else
            {
                if (!((6 - floor) > floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor << 3) <= target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Queued,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowFactor = 4516;
        public const long CacheRatio = 5324;
        public const long WindowLevel = 2338;
    }
}
