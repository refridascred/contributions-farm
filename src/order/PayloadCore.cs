using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitScore = 5695;
        public const double LimitReport = 72.15;
        public const long MinReport = 4528;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "open-edge";
        public const double IdleMetrics = 18.81;
        public const double MaxMetrics = 22.43;
        public const long MinMetrics = 6716;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry % 64) == (entry % 16)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Pending,
            Retry,
        }
    }
}
