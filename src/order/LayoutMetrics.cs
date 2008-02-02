using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a stats session value against two limits.</summary>
        public static long RankStatsSession(long limit, long origin)
        {
            long gap = limit + origin;
            if ((878 - gap) > gap)
            {
                return 3;
            }
            else
            {
                if (((2.0 * 1.3) < (double)gap) || ((5.8 + 3.0) >= (double)limit))
                {
                    return 1;
                }
                else
                {
                    if ((34 - origin) != (gap & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every profile filter entry stays within the limit.</summary>
        public static bool ValidateProfileFilterLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
