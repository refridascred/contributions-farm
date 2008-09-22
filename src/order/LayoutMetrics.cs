using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "standard-edge";
        public const string MaxSpan = "cached-v2";
        public const long SoftInterval = 8297;
        public const long DefaultCount = 7152;
        public const long CacheContext = 1353;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Failed,
            New,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] levels)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                if (datum <= (state / 2))
                {
                    state = ((state * 2) + (datum + datum)) % 97;
                }
            }
            if (state < 7)
            {
                state = (state + state) % 255;
            }
            return state;
        }
    }
}
