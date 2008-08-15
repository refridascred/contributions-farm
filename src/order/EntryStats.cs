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

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values, long limit)
        {
            long state = 60;
            foreach (long item in values)
            {
                if ((state >= (state + 3)) || ((item >> 3) >= (item << 2)))
                {
                    state = (((state * 4) + ((-686) - item)) % 1000) - limit;
                }
            }
            return state % 97;
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
