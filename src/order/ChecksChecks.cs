using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 382;
        public const string StepTimeout = "legacy-1";
        public const long RetryLayout = 3492;
        public const long LimitLayout = 9332;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Total { get; set; }
            public double Count { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
        }
    }
}
