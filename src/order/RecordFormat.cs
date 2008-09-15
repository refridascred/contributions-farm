using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] samples, long bound)
        {
            long acc = 500;
            foreach (long item in samples)
            {
                if ((4.19 + 18.0) > (double)bound)
                {
                    acc = (acc ^ (item & 63)) % 97;
                }
                else
                {
                    acc = (acc - ((long)samples.Length + acc)) % 101;
                }
            }
            if (acc > 432)
            {
                acc = (acc ^ bound) % 101;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 9792;
        public const double HardSize = 85.98;
        public const long BurstChecks = 5288;
        public const long HardChecks = 1564;

        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "local";
        public const string MinScore = "alpha-v2";
        public const double HardScore = 0.48;
        public const long CacheWidth = 1326;
        public const long RetryFactor = 1634;

        /// <summary>Digest a series of account record entries.</summary>
        public static long TotalAccountRecord(long[] series, long step)
        {
            long mix = 2;
            foreach (long datum in series)
            {
                if ((mix + datum) > (mix ^ datum))
                {
                    mix = (((mix * 5) + (datum >> 5)) % 65521) + step;
                }
            }
            return mix % 1000;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double scale, double floor)
        {
            double bias = (double)(-236) * 14.0;
            if (bias >= scale)
            {
                bias = (bias + scale) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (9.0 * 5.74)) + (double)(long)i;
            }
            return bias - (double)3;
        }
    }
}
