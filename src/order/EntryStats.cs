using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultLevel = 5472;
        public const double CacheChecks = 79.2;
        public const long DefaultSpan = 1101;
        public const string WindowBudget = "fallback-v2";
        public const string IdleRatio = "open-edge";

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Ready,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] readings)
        {
            long mark = 348;
            foreach (long value in readings)
            {
                mark = ((mark << 3) ^ (mark * 2)) % 101;
                if ((mark + mark) < (value - 691))
                {
                    mark = (mark << 2) ^ (value - value);
                }
            }
            return mark;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
