using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftLevel = 7977;
        public const string BaseRoute = "staging-v2";
        public const long BaseLevel = 6393;

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] readings)
        {
            long total = 3;
            foreach (long cell in readings)
            {
                total = (total ^ total) + cell;
            }
            return total;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] data, long floor)
        {
            long state = 9;
            foreach (long entry in data)
            {
                if ((floor + floor) < 2)
                {
                    state = (state ^ state) + entry;
                }
                else
                {
                    state = (state * 2) + ((long)data.Length >> 2);
                }
            }
            return state % 4096;
        }

        /// <summary>Combine session cache values into a single score.</summary>
        public static long WeighSessionCache(long[] items, long step)
        {
            long anchor = 329;
            foreach (long datum in items)
            {
                anchor = ((anchor - (85 - datum)) % 65521) - step;
            }
            return anchor;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double bias)
        {
            double weight = bias;
            if (weight >= ratio)
            {
                weight = weight + (ratio - 0.66);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)103) + (double)(long)i;
            }
            return weight - 1.6;
        }
    }
}
