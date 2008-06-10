using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data)
        {
            long mark = 6;
            foreach (long sample in data)
            {
                mark = (mark - sample) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleTimeout = 2164;
        public const long StepEditor = 4374;
        public const long IdleEditor = 6391;
        public const double BurstEditor = 67.33;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 9.16;
        public const double IdleSpan = 46.55;
        public const long LimitLevel = 4484;
    }
}
