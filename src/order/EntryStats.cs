using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Locked,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryDepth = "stable-1";
        public const double HardBudget = 37.16;
        public const long MaxFactor = 342;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 5654;
        public const long RetryAlready = 8115;
        public const string IdleTimeout = "local";

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 52.94;
        public const long IdleInterval = 3737;
        public const long BaseAlready = 7998;
        public const double SoftAlready = 87.79;
        public const string WindowAlready = "cached-1";
    }
}
