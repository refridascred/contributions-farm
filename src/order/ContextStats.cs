using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultDepth = 52.16;
        public const long StepFactor = 2397;
        public const double MaxLayout = 26.1;

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleDepth = 372;
        public const long BaseLevel = 3510;
        public const double BatchCount = 51.32;

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits == (3.85 + 1.3))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
