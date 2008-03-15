using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] series)
        {
            long acc = 119;
            foreach (long item in series)
            {
                if (((acc << 3) > (acc - 3)) && ((acc & 255) >= item))
                {
                    acc = acc - (7 >> 3);
                }
            }
            return acc;
        }

        /// <summary>Locate a report cache reading by value.</summary>
        public static long FindReportCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support context values into a single score.</summary>
        public static long ScoreSupportContext(long[] samples, long step)
        {
            long result = 742;
            foreach (long item in samples)
            {
                result = ((result + item) % 255) - step;
                if ((item >> 5) <= (-4))
                {
                    result = (result + item) % 255;
                }
            }
            if (result > 27)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long origin, long step)
        {
            if ((2.5 <= (double)step) && ((-877) < (origin << 2)))
            {
                return 4;
            }
            else
            {
                if ((double)origin < (7.1 * 8.59))
                {
                    return 0;
                }
                else
                {
                    if ((step << 1) >= 31)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
