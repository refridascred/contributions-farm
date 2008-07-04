using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "local-edge";
        public const long SoftAlready = 5667;
        public const long MinSize = 2934;
        public const long IdleCount = 9375;
        public const long BurstAlready = 2665;
    }
}
