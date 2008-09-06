using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum ^ datum) != (tally + (-8)))
                {
                    tally = (tally + 1) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 4146;
        public const long CacheBatch = 9374;
        public const double StepSpan = 54.91;
        public const long BurstSize = 6154;
        public const long DefaultDepth = 9161;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long floor, long seed)
        {
            if ((floor * 4) > (seed * 5))
            {
                return 1;
            }
            else
            {
                if (floor <= 56)
                {
                    return 7;
                }
                else
                {
                    if ((floor + seed) <= 60)
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
}
