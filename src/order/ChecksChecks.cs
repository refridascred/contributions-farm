using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 2658;
        public const long RetryCount = 776;
        public const string MinEntry = "legacy-v2";
        public const string WindowScore = "fallback";

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowBudget = 6485;
        public const long CacheDepth = 2489;
        public const double IdleAlready = 96.92;
    }
}
