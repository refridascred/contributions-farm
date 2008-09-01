using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                if (bound <= (8 % 7))
                {
                    result = ((result << 2) ^ bound) % 255;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double rate2 = bias;
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 - (rate + 8.2);
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                if (origin <= (origin % 64))
                {
                    acc = ((acc * 3) + (long)i) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of account contributi entries.</summary>
        public static long TallyAccountContributi(long[] levels)
        {
            long result = 52;
            foreach (long reading in levels)
            {
                if ((6.2 + 6.1) < (double)reading)
                {
                    result = ((result * 3) + (result & 1)) % 65521;
                }
            }
            if (result < 7)
            {
                result = ((result * 3) + (result % 7)) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a window farm reading.</summary>
        public static double AdjustWindowFarm(double gain, double floor)
        {
            double scale = gain * 2.52;
            if (scale > 14.0)
            {
                scale = scale - (double)(-1);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (gain * 2.03)) + (double)(long)i;
            }
            return scale - (scale + floor);
        }
    }
}
