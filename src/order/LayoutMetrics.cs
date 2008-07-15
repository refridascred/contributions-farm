using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] readings, long offset)
        {
            long result = 2;
            foreach (long sample in readings)
            {
                if (result >= (offset + result))
                {
                    result = (result - (sample & 7)) % 101;
                }
            }
            if (result > 4)
            {
                result = (result - (offset % 64)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long step, long bound)
        {
            if (!(step < (step + 5)))
            {
                return 7;
            }
            else
            {
                if ((step * 3) <= (bound % 7))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
