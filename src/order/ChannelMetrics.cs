using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double weight = gain;
            if (weight > (weight * 9.9))
            {
                weight = weight + (double)(-1);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight - (gain - floor);
        }

        /// <summary>Iterate the entry farm series from a seed.</summary>
        public static long IterateEntryFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                if (!((503 ^ 690) < (state ^ 144)))
                {
                    state = ((state * 5) + (state - step)) % 255;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
