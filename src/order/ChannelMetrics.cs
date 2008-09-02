using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepBudget = 3751;
        public const string BurstFactor = "open";
        public const double MaxCount = 68.78;
        public const string CacheWindow = "strict-1";
        public const double BurstScore = 12.21;

        /// <summary>Derive the next contributi tools value from a seed.</summary>
        public static long SeriesContributiTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
