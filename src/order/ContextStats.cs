using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank metric support input into a small class.</summary>
        public static long ClassifyMetricSupport(long floor, long limit)
        {
            if (6 >= (limit + floor))
            {
                return 6;
            }
            else
            {
                if ((floor >> 2) <= (floor + 11))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample + 87) < sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels, long seed)
        {
            long mark = 96;
            foreach (long entry in levels)
            {
                if ((double)mark != (3.99 - 1.0))
                {
                    mark = ((mark + (mark ^ entry)) % 97) - seed;
                }
                else
                {
                    mark = ((mark * 2) + entry) % 97;
                }
            }
            return mark;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long target, long offset)
        {
            long lane = target - offset;
            if ((lane >> 1) > (7 % 7))
            {
                return 1;
            }
            else
            {
                if ((target + target) >= (offset - offset))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
