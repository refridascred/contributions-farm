using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowScore = 514;
        public const long LimitFilter = 5809;
        public const long WindowFilter = 4048;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 43.97;
        public const long SoftRatio = 7363;
        public const long MinFarm = 4412;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Size { get; set; }
        }
    }
}
