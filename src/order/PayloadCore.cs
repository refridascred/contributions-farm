using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double weight = 0.5;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (floor + weight)) - (double)(long)i) + rate;
            }
            return weight - floor;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix + (target * 2)) % 1000;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a format schema value against two limits.</summary>
        public static long ClassifyFormatSchema(long offset, long floor)
        {
            long slot = offset + floor;
            if (((slot + floor) != (slot - offset)) || ((double)offset < 17.0))
            {
                return 0;
            }
            else
            {
                if ((double)offset != (8.82 - 2.4))
                {
                    return 7;
                }
                else
                {
                    if (((-197) * 3) >= (offset / 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "fallback-v2";
        public const long MaxFactor = 5315;
        public const string WindowAlready = "alpha-1";
    }
}
