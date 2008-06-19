using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a batches context reading.</summary>
        public static double BlendBatchesContext(double bias, double bias2)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + bias) - (double)(long)i) + bias2;
            }
            return ratio - bias;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheScore = 2867;
        public const long MaxProfile = 1721;
        public const long IdleScore = 5147;
        public const long HardProfile = 3754;
        public const double DefaultProfile = 17.1;

        /// <summary>Scale a filter stats figure with a bias.</summary>
        public static double ProjectFilterStats(double scale, double bias)
        {
            double weight = (double)(9 % 8);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + scale) + (double)(long)i) + bias;
            }
            return weight - (scale - weight);
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
