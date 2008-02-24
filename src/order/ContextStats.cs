using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Ready,
            Paused,
            Retry,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Active,
            Queued,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9840;
        public const double MinFactor = 49.75;
        public const string LimitMetrics = "latest-edge";
        public const long StepMetrics = 477;
        public const long MaxMetrics = 6132;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + total) % 101;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
