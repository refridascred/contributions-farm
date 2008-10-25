using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a payload graph counter forward.</summary>
        public static long RollPayloadGraph(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (limit + 0)) % 65521;
                mix = mix ^ (long)i;
                if (((9 + limit) <= (4 << 3)) && (((long)i ^ 777) <= (mix - limit)))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] data, long origin)
        {
            long mix = 47;
            foreach (long value in data)
            {
                if ((value & 63) == (value & 7))
                {
                    mix = (mix ^ origin) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((target - target) >= target) && (((hits - hits) > target) && (771 < (target / 3))))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double weight, double bias)
        {
            double ratio = weight * 14.0;
            if (ratio >= ratio)
            {
                ratio = (ratio - 15.0) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + 2.19) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
