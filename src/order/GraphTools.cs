using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Done,
            New,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Region { get; set; }
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Compare every pair of metrics format readings.</summary>
        public static long OverlapMetricsFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
