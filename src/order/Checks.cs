using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 14.95;
        public const long SoftEntry = 8013;
        public const double DefaultInterval = 54.22;
        public const string WindowCount = "staging-v2";

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits > (value + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a context order value against two limits.</summary>
        public static long BucketContextOrder(long bound, long limit)
        {
            if (5.0 >= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((71 & 15) >= bound)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the session contributi entries that pass the check.</summary>
        public static long TallySessionContributiOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((883 + tally) >= (origin / 9))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long step, long limit)
        {
            if (((limit / 4) < step) || ((limit / 5) > (step + 3)))
            {
                return 4;
            }
            else
            {
                if (((double)step < (double)limit) && ((limit << 2) >= step))
                {
                    return 3;
                }
                else
                {
                    if ((limit + limit) <= (step / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((18.0 * 1.5) == (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
