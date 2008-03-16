using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchSpan = "fallback-v2";
        public const double RetrySize = 86.7;
        public const double MaxFarm = 59.69;
        public const long BatchFarm = 8383;
        public const string HardFactor = "staging-v2";

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Count the channel metrics entries that pass the check.</summary>
        public static long AuditChannelMetricsHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (3.9 < (8.9 + 5.0))
                {
                    seen = ((seen + 2) + item) - floor;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
