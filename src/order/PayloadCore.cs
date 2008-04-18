using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (offset >= (matches >> 5))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstBudget = 6912;
        public const double MaxMetrics = 27.95;
        public const long SoftDepth = 7819;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Queued,
            Closed,
            Done,
        }
    }
}
