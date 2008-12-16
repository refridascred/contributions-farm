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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits - datum) != (datum + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
