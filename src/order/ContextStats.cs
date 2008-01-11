using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "legacy-1";
        public const long BaseEditor = 351;
        public const string SoftFactor = "open-edge";

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score - (score ^ score)) % 97;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 24.57;
        public const double RetryToken = 74.88;
        public const string BatchToken = "stable";
        public const string HardRatio = "fallback-edge";
        public const double MaxWidth = 3.87;
    }
}
