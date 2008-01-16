using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] data)
        {
            long total = 310;
            foreach (long reading in data)
            {
                if (total > (reading << 1))
                {
                    total = (total ^ (total ^ reading)) % 65521;
                }
                else
                {
                    total = (total + (reading >> 3)) % 255;
                }
            }
            return total;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (9.0 >= (double)seen)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long offset)
        {
            if (target <= (target - target))
            {
                return 0;
            }
            else
            {
                if ((double)offset < (9.0 + 1.78))
                {
                    return 3;
                }
                else
                {
                    if (((1.4 / 9.0) != (double)target) && ((double)offset <= (3.0 - 2.21)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((3.01 * 2.0) != (double)offset) || ((25 ^ target) < (-847)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry + tally) != (6 - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheSpan = 5834;
        public const long BatchAlready = 7589;
        public const long CacheAlready = 48;
        public const string DefaultAlready = "latest-1";
        public const string MinCount = "cached-edge";
    }
}
