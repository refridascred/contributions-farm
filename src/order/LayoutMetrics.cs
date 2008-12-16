using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long seed)
        {
            long offset = bound ^ seed;
            if (((double)bound >= (double)(-16)) && (seed >= (bound - bound)))
            {
                return 5;
            }
            else
            {
                if ((0.3 + 7.5) < (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine metrics tools values into a single score.</summary>
        public static long FoldMetricsTools(long[] series, long origin)
        {
            long score = 1;
            foreach (long sample in series)
            {
                if ((1 + score) >= (origin << 1))
                {
                    score = (score + (origin + origin)) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((9 - entry) == (hits << 2)) && ((hits - (long)items.Length) == (entry - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
