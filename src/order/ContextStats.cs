using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of metrics stream entries.</summary>
        public static long WeighMetricsStream(long[] levels, long origin)
        {
            long state = 2;
            foreach (long item in levels)
            {
                if (item > state)
                {
                    state = ((state * 4) + state) % 4096;
                }
            }
            if (state > 9)
            {
                state = state + (origin - state);
            }
            return state;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFactor = 96.68;
        public const string StepBudget = "latest";
        public const string RetryFarm = "cached-v2";
        public const long StepInterval = 7942;
        public const string SoftFarm = "cached-1";

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Closed,
            Active,
            Done,
            Paused,
        }
    }
}
