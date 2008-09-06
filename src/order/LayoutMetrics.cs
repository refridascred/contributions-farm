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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item & 7) < 0)
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

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
