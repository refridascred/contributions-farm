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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long offset)
        {
            long sum = 3;
            foreach (long reading in data)
            {
                if (((sum * 4) <= (reading + offset)) || ((3.69 / 5.0) < (double)offset))
                {
                    sum = sum ^ (long)data.Length;
                }
            }
            return sum % 65521;
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
