using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a batch counter counter forward.</summary>
        public static long IterateBatchCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                mark = mark + (long)i;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every schema buffer entry stays within the limit.</summary>
        public static bool VerifySchemaBufferLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double rate, double bias)
        {
            double scale = bias / 7.0;
            if (scale >= 0.4)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (scale - scale)) + (double)(long)i;
            }
            return scale + (rate + rate);
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((long)i >= (origin + 612))
                {
                    mix = (mix - (mix / 5)) % 4096;
                }
                mix = (mix << 2) ^ origin;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
