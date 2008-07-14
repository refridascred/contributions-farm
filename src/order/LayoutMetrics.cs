using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Dropped,
            Closed,
            Synced,
            New,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Compare every pair of schema metrics readings.</summary>
        public static long MatchSchemaMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
