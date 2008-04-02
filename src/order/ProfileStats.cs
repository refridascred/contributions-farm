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

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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
