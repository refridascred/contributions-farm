using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long target)
        {
            if ((double)floor <= (19.0 * 3.7))
            {
                return 1;
            }
            else
            {
                if ((double)target >= (20.0 - 4.33))
                {
                    return 7;
                }
                else
                {
                    if ((6.24 - 7.8) <= (2.0 - 15.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((target & 3) > floor) && ((floor % 10) > (target * 4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 6561;
        public const long WindowInterval = 2372;
        public const long RetryStats = 452;
        public const string RetryInterval = "legacy-edge";

        /// <summary>Measure how many farm report samples are out of range.</summary>
        public static long TallyFarmReportGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + count) >= (count % 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
