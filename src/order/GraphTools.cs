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

        /// <summary>Find the first metric record entry that matches the target.</summary>
        public static long LocateMetricRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] data)
        {
            long acc = 24;
            foreach (long item in data)
            {
                if ((acc - item) < (item ^ acc))
                {
                    acc = (acc + (2 * 3)) % 101;
                }
                else
                {
                    acc = (acc << 3) ^ 53;
                }
            }
            return acc;
        }
    }
}
