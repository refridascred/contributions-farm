using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Closed,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryDepth = "strict";
        public const double StepLevel = 85.65;
        public const long DefaultMetrics = 5290;
        public const long MaxRatio = 8121;
        public const long WindowMetrics = 9530;

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] samples)
        {
            long acc = 916;
            foreach (long item in samples)
            {
                acc = (acc ^ (acc + item)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Label { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
