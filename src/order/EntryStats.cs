using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 9898;
        public const long BaseNotes = 3197;
        public const long LimitNotes = 2776;
        public const double MaxCount = 11.96;

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftBudget = 8209;
        public const long BatchEntry = 3364;
        public const long SoftEntry = 9109;

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepFactor = 2530;
        public const string RetryInterval = "strict-1";
        public const long LimitCount = 6374;
        public const double MaxFactor = 36.74;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheDepth = "alpha-edge";
        public const long WindowSize = 729;
        public const long DefaultWidth = 7067;
    }
}
