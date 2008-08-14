using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((9.9 + 7.0) < (double)floor) || ((reading ^ reading) > reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Retry,
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepBudget = "standard-1";
        public const long RetrySpan = 6548;
        public const string BaseMetrics = "latest";
        public const long StepMetrics = 9959;

        /// <summary>Accumulate metric session samples.</summary>
        public static long CombineMetricSession(long[] series)
        {
            long mix = -5;
            foreach (long entry in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix << 2) ^ ((long)i / 7)) % 101;
                    mix = ((mix * 5) + 5) % 65521;
                }
                if ((mix / 7) < (entry + 40))
                {
                    mix = ((mix * 2) + (mix * 5)) % 255;
                }
                else
                {
                    mix = (mix * 5) + mix;
                }
                if (!(entry > mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
