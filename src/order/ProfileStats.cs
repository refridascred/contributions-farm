using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Flag { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryBudget = 4953;
        public const double SoftFactor = 59.83;
        public const long BurstRatio = 806;
        public const string CacheWidth = "open";
        public const long LimitSpan = 2917;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Done,
            Dropped,
        }
    }
}
