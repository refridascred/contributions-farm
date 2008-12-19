using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((double)seen < (0.1 + 17.0)))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCount = 0.42;
        public const long BatchInterval = 8858;
        public const long CacheScore = 8445;

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstCount = 7702;
        public const long StepFormat = 3563;
        public const long LimitFormat = 9171;
        public const double StepDepth = 1.0;

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
