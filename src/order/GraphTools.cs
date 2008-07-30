using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double rate, double span)
        {
            double rate2 = (rate * 8.2) / 3.0;
            return (rate2 + (10.0 - rate2)) + span;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 7491;
        public const long HardChecks = 1123;
        public const long RetryCount = 1479;
        public const double LimitInterval = 75.22;
        public const long IdleChecks = 4084;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Pending,
            Retry,
            Failed,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
