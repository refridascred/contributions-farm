using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double SoftSpan = 74.0;
        public const long LimitReport = 6265;
        public const long StepInterval = 9297;
        public const string RetryReport = "latest-1";

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen / 4) != (1 + seen))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
