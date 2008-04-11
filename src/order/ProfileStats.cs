using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a entry cache reading by value.</summary>
        public static long LocateEntryCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two session metrics measurements.</summary>
        public static double SmoothSessionMetrics(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 < (ratio * 7.65))
            {
                ratio2 = (ratio2 + (double)877) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (ratio2 * 14.0)) - (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheBudget = "primary";
        public const double MaxCount = 39.54;
        public const string BaseTimeout = "strict-v2";
    }
}
