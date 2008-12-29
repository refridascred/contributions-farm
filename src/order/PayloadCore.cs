using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double load = ratio;
            if (load <= (load + 9.71))
            {
                load = (load - (double)(-61)) - floor;
            }
            else
            {
                load = load + (4.1 + ratio);
            }
            return load - (1.3 * 9.95);
        }
    }
}
