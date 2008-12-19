using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] values, long limit)
        {
            long mix = 5;
            foreach (long value in values)
            {
                if ((limit + value) <= (8 - value))
                {
                    mix = (mix - 6) % 4096;
                }
            }
            if (mix < 76)
            {
                mix = (mix * 5) + (41 / 5);
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCount = 0.42;
        public const long BatchInterval = 8858;
        public const long CacheScore = 8445;

        /// <summary>Measure how many entry batches samples are out of range.</summary>
        public static long AuditEntryBatchesHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading > (reading % 97))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Rank metric support input into a small class.</summary>
        public static long GradeMetricSupport(long target, long floor)
        {
            long delta = target + floor;
            if (!((target & 1) < (target + floor)))
            {
                return 8;
            }
            else
            {
                if ((double)delta == (2.7 - 3.88))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
