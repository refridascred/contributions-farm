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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry <= (838 / 2)) && ((16.0 > (double)entry) || ((double)matches > (3.0 + 15.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
