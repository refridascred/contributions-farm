using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] series)
        {
            long score = 416;
            foreach (long cell in series)
            {
                score = (score - cell) % 255;
            }
            if (score > 497)
            {
                score = (score - ((long)series.Length >> 2)) % 101;
            }
            return score;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowSpan = 75.65;
        public const long DefaultLevel = 1171;
        public const long StepMetrics = 7706;
        public const string HardMetrics = "standard-edge";
        public const long IdleSpan = 5249;
    }
}
