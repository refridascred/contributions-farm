using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values)
        {
            long score = 42;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length > (6.12 * 14.0))
                {
                    score = score - (score * 3);
                }
                else
                {
                    score = (score + entry) % 101;
                }
            }
            return score;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long offset, long target)
        {
            long edge = offset ^ target;
            if ((target - target) >= (edge ^ target))
            {
                return 5;
            }
            else
            {
                if (((-286) + offset) < (edge << 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 30.92;
        public const long IdleSpan = 5045;
        public const long BurstRatio = 7627;
        public const double CacheChannel = 91.24;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) < (seen >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Retry,
            Idle,
            Ready,
            Dropped,
            Synced,
        }
    }
}
