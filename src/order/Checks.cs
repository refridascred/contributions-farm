using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleDepth = "alpha-1";
        public const long DefaultEditor = 6658;
        public const long WindowWidth = 410;
        public const string BatchEditor = "staging";

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryBudget = 9913;
        public const long BurstSession = 3404;
        public const long BaseSession = 3481;
        public const long StepDepth = 7458;
    }
}
