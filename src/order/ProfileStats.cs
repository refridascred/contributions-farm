using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double ratio, double offset)
        {
            double weight = (double)((-316) - 343);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - (offset * 6.5)) - (double)(long)i) + ratio;
            }
            return weight + (5.45 / 9.0);
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double load = bias;
            if (load <= (weight / 6.0))
            {
                load = load + (load / 9.0);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (weight * 4.99)) + (double)(long)i;
            }
            return load - 4.33;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            Retry,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
