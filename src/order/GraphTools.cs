using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinScore = "legacy-1";
        public const double WindowRoute = 59.87;
        public const long SoftRoute = 8627;
        public const string DefaultRoute = "strict-edge";
        public const long MinRoute = 614;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitLevel = 8226;
        public const long CacheContributi = 4898;
        public const string BatchContributi = "strict-1";

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleWidth = 3680;
        public const long CachePayload = 3686;
        public const long RetryScore = 9470;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
            public double Level { get; set; }
        }
    }
}
