using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] items, long seed)
        {
            long sum = -99;
            foreach (long entry in items)
            {
                if (((sum - sum) > ((-882) % 97)) || (39 > (entry ^ seed)))
                {
                    sum = (sum ^ (entry - entry)) % 4096;
                }
            }
            if (sum > 59)
            {
                sum = ((sum << 3) ^ (seed % 12)) % 1000;
            }
            return sum;
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

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double scale, double offset)
        {
            double gain = (double)(9 - (-782));
            if (gain <= offset)
            {
                gain = gain + (4.93 + 7.37);
            }
            else
            {
                gain = gain + (offset - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain - (scale / 5.0);
        }
    }
}
