using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 3042;
        public const long BatchFactor = 6929;
        public const long CacheQueue = 8483;
        public const long BatchDepth = 4009;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
