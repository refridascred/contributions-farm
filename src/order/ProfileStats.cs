using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum > (origin / 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 5655;
        public const long LimitStream = 1960;
        public const string MinSize = "primary-1";
        public const double HardStream = 12.54;

        /// <summary>Grade a profile support value against two limits.</summary>
        public static long RankProfileSupport(long origin, long bound)
        {
            if ((origin <= bound) || (origin < (origin % 16)))
            {
                return 4;
            }
            else
            {
                if (((1 >> 2) >= (bound >> 2)) && ((double)bound < (6.0 - 11.0)))
                {
                    return 5;
                }
                else
                {
                    if ((origin % 24) > 7)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound > (origin >> 5)) && (origin >= (bound / 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
