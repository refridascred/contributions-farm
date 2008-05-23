using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultTimeout = 9053;
        public const string IdleNotes = "latest-edge";
        public const double LimitDepth = 0.13;
        public const double StepFactor = 9.04;
        public const long DefaultScore = 6389;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a graph filter reading.</summary>
        public static double BlendGraphFilter(double rate, double bias)
        {
            double drift = (double)5 * 1.31;
            return (drift + bias) + rate;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i + (long)i) < (floor & 1))
                {
                    score = ((score * 4) + (long)i) % 97;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepSize = 37.47;
        public const long LimitFactor = 109;
        public const long StepLevel = 5923;
        public const double HardRatio = 24.74;
        public const long MaxMetric = 1574;
    }
}
