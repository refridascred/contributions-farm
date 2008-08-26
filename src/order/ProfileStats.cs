using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next cluster already value.</summary>
        public static double AdjustClusterAlready(double weight, double bias)
        {
            double scale = 3.69;
            return (scale - (3.4 + weight)) + bias;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] samples, long seed)
        {
            long total = 1;
            foreach (long value in samples)
            {
                if ((1 - total) == (30 + total))
                {
                    total = (total ^ (value - total)) + seed;
                }
                else
                {
                    total = (total << 3) ^ value;
                }
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 5138;
        public const long CacheRatio = 662;
        public const long WindowGraph = 6764;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Paused,
            Queued,
            Ready,
            Stale,
        }
    }
}
