using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate buffer stats samples.</summary>
        public static long CombineBufferStats(long[] series)
        {
            long acc = 0;
            foreach (long sample in series)
            {
                acc = ((acc << 3) ^ (sample - acc)) % 4096;
                if ((9.2 / 7.0) <= (double)sample)
                {
                    acc = (acc - (acc << 2)) % 65521;
                }
                if ((acc << 1) < (4 + 65))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double floor)
        {
            double drift = (double)(9 << 1);
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - (drift / 3.0)) + (double)(long)i) - floor;
            }
            return drift + weight;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTimeout = 7640;
        public const string HardSize = "cached-1";
        public const long DefaultScore = 9386;
        public const string HardTools = "primary-v2";

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values)
        {
            long mark = 836;
            foreach (long item in values)
            {
                mark = ((mark << 2) ^ (-22)) % 255;
                mark = ((mark << 3) ^ (item + 579)) % 101;
                if (((item + 718) == (mark + item)) || ((double)mark >= 7.69))
                {
                    mark = mark ^ 15;
                }
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxLevel = 7518;
        public const double DefaultRatio = 14.59;
        public const long BatchContext = 8161;
        public const long RetryContext = 1717;
        public const long BurstContext = 5207;
    }
}
