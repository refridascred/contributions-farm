using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardSize = 8726;
        public const long BaseContributi = 3084;
        public const long WindowFactor = 9517;
        public const double SoftBudget = 23.01;
        public const double RetryContributi = 62.73;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Synced,
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
