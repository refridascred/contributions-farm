using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchWidth = "staging-edge";
        public const long SoftCluster = 3562;
        public const double HardCluster = 47.75;
        public const double BaseLevel = 93.68;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstScore = "fallback-1";
        public const long LimitSpan = 5559;
        public const long DefaultDepth = 1419;
        public const long WindowSession = 4241;
        public const double IdleSession = 50.79;
    }
}
