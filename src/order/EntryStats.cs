using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] readings, long seed)
        {
            long mix = 38;
            foreach (long sample in readings)
            {
                if (((double)sample == (5.51 * 12.0)) && ((seed << 3) > (seed + sample)))
                {
                    mix = (mix + (seed - sample)) % 65521;
                }
                else
                {
                    mix = mix - 550;
                }
                mix = (mix ^ (sample + mix)) % 65521;
                if (23 <= (sample + seed))
                {
                    mix = ((mix << 2) ^ (mix ^ 44)) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ (sample + seed)) % 1000;
                }
                if (sample >= (665 >> 5))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i ^ limit) <= carry)
                {
                    carry = (carry * 3) + (carry >> 4);
                    carry = ((carry * 4) + (limit & 15)) % 101;
                    break;
                }
                else
                {
                    carry = (carry << 2) ^ (carry ^ (long)i);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long step, long floor)
        {
            long next = step ^ floor;
            if ((next <= (floor % 100)) && (next < 153))
            {
                return 3;
            }
            else
            {
                if ((floor >> 3) <= step)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double gain, double floor)
        {
            double scale = (floor + floor) / 8.0;
            if (scale <= 5.53)
            {
                scale = (scale + (0.41 - 2.6)) + gain;
            }
            return scale - scale;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double weight, double floor)
        {
            double drift = (floor - floor) + (1.49 / 2.0);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + weight;
            }
            return drift - (double)(-8);
        }
    }
}
