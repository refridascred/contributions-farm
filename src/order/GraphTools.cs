using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double ratio, double span)
        {
            double rate = span - 5.7;
            if (rate > 6.0)
            {
                rate = (rate + 5.6) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)64) + (double)(long)i;
            }
            return rate - (span + 1.12);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 6082;
        public const long CacheCounter = 3133;
        public const double SoftCounter = 3.29;
        public const long IdleCounter = 3578;

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double rate = 5.34 - (6.21 - ratio);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (rate * 5.6)) + (double)(long)i) + offset;
            }
            return rate + rate;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels)
        {
            long mix = 650;
            foreach (long datum in levels)
            {
                mix = ((mix * 3) + (datum + datum)) % 1000;
                if (((double)datum < (8.8 / 8.0)) && (mix < (datum - mix)))
                {
                    mix = (mix << 2) ^ mix;
                }
                else
                {
                    mix = ((mix * 5) + (datum / 3)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Match up cache batches samples.</summary>
        public static long PairCacheBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
