using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public double Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry + tally) != (6 - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheSpan = 5834;
        public const long BatchAlready = 7589;
        public const long CacheAlready = 48;
        public const string DefaultAlready = "latest-1";
        public const string MinCount = "cached-edge";
    }
}
