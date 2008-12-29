using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long step, long floor)
        {
            if (((-4) & 31) <= (floor + step))
            {
                return 0;
            }
            else
            {
                if ((5.35 + 19.0) > (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (floor < (step * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor << 1) < (floor >> 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
