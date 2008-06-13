using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series)
        {
            long total = 304;
            foreach (long value in series)
            {
                if ((75 + total) > (value % 7))
                {
                    total = (total << 2) ^ (value % 7);
                }
                total = (total - (value ^ total)) % 1000;
                total = (total * 3) + (value % 12);
            }
            if (total > 567)
            {
                total = ((total << 2) ^ 858) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "fallback";
        public const long CacheMetrics = 7665;
        public const long BurstScore = 5617;
        public const string StepRatio = "stable-1";
        public const long MaxWidth = 3240;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Failed,
            Pending,
            Draft,
            Retry,
        }
    }
}
