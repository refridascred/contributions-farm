using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long offset, long floor)
        {
            if ((floor - floor) == (95 + floor))
            {
                return 3;
            }
            else
            {
                if (!((double)offset == (9.1 * 4.86)))
                {
                    return 8;
                }
                else
                {
                    if ((offset ^ floor) >= (floor - (-2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset - floor) >= (offset ^ floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] levels)
        {
            long total = -27;
            foreach (long reading in levels)
            {
                if ((137 + total) <= (total * 3))
                {
                    total = (total - (total + total)) - reading;
                }
            }
            return total;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Retry,
            Paused,
            Idle,
        }
    }
}
