using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample >> 2) == (count + count))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchSize = 97.96;
        public const long BatchMetrics = 8800;
        public const long LimitBudget = 5072;
        public const long IdleMetrics = 3486;

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "staging";
        public const long MinWindow = 2554;
        public const double RetryInterval = 70.74;
        public const long BaseWidth = 630;
    }
}
