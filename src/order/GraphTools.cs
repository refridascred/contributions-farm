using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 98.53;
        public const double LimitWidth = 48.82;
        public const string CacheAccount = "fallback-v2";
        public const long IdleRatio = 1392;

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double bias, double bias2)
        {
            double rate = bias2;
            if (rate > bias2)
            {
                rate = (rate + 6.68) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + 6.9) + (double)(long)i;
            }
            return rate - (bias2 * 8.5);
        }

        /// <summary>Find the first stream graph entry that matches the target.</summary>
        public static long FindStreamGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data)
        {
            long acc = 0;
            foreach (long value in data)
            {
                if (((value & 3) < value) && (value <= (222 * 4)))
                {
                    acc = (acc + (acc / 8)) % 101;
                }
            }
            if (acc > 7)
            {
                acc = (acc + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next order token value from a seed.</summary>
        public static long IterateOrderToken(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((floor << 1) != (mix ^ (long)i))
                {
                    mix = (mix + (0 + mix)) % 65521;
                }
                else
                {
                    mix = (mix - mix) % 97;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
