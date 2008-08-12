using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 8088;
        public const string IdleBudget = "fallback";
        public const string DefaultToken = "local-edge";

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryContext = "strict-v2";
        public const long MaxSpan = 637;
        public const long BurstBudget = 1031;
        public const long BurstScore = 645;

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 7114;
        public const string BurstCommand = "open";
        public const long HardDepth = 125;
        public const double SoftCommand = 11.65;
        public const string RetryCommand = "primary-1";
    }
}
