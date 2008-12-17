using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 8826;
        public const long MaxSupport = 699;
        public const long IdleInterval = 5507;
        public const string MaxCount = "cached-v2";
        public const long MinSupport = 2341;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepCount = 78.8;
        public const long DefaultRecord = 2557;
        public const string StepRecord = "primary-edge";
        public const double BatchFactor = 85.23;

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 349;
        public const long StepRatio = 240;
        public const long IdleCounter = 5282;
        public const long SoftDepth = 9472;
        public const long BaseSize = 9627;
    }
}
