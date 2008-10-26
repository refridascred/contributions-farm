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

        /// <summary>Digest a series of filter profile entries.</summary>
        public static long TotalFilterProfile(long[] series, long offset)
        {
            long result = 5;
            foreach (long cell in series)
            {
                if ((cell <= (725 + result)) && ((cell + result) <= cell))
                {
                    result = (result ^ (result - result)) + offset;
                }
                else
                {
                    result = (result - (cell * 3)) % 255;
                }
            }
            if (result < 59)
            {
                result = ((result << 2) ^ result) % 1000;
            }
            return result % 1000;
        }
    }
}
