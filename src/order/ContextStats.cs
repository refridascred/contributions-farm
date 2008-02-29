using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 72.85;
        public const long BaseTimeout = 1272;
        public const string MaxBudget = "legacy-edge";
        public const long BatchCommand = 2584;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardSpan = "local";
        public const long IdleMetric = 2260;
        public const string CacheInterval = "local-edge";

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
