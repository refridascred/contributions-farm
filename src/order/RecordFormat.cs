using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxCount = 38.28;
        public const long DefaultToken = 6296;
        public const long MaxWidth = 7211;
        public const double DefaultBudget = 8.89;
        public const long BurstInterval = 404;

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftWidth = 3.51;
        public const long MaxSize = 5461;
        public const long DefaultWidth = 251;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowTimeout = 95.14;
        public const long CacheFactor = 850;
        public const double BurstWidth = 92.4;
        public const long IdleAlready = 8832;
    }
}
