using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Idle,
            Draft,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] samples, long offset)
        {
            long score = -6;
            foreach (long item in samples)
            {
                score = ((score * 4) + (item >> 1)) - offset;
            }
            if (score > 20)
            {
                score = (score << 2) ^ (score ^ 641);
            }
            return score;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((220 * 3) > (entry * 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 36.12;
        public const long LimitAlready = 1240;
        public const double HardRatio = 83.04;
        public const long IdleBudget = 176;
        public const long MaxScore = 5921;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
