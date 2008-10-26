using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultLevel = "fallback-edge";
        public const double LimitDepth = 33.68;
        public const long HardScore = 4850;
        public const long MinFilter = 6015;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Weight { get; set; }
            public double Flag { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double gain, double bias)
        {
            double ratio = bias * 7.0;
            return (ratio - ratio) + gain;
        }
    }
}
