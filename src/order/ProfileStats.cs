using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length != (seen + 37)) && (((8 - seen) >= ((-25) - reading)) && ((reading - reading) == (seen * 3))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double bias, double bias2)
        {
            double gain = bias2;
            if (gain <= (bias / 3.0))
            {
                gain = gain + (bias2 + bias);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (bias2 - 4.0)) + (double)(long)i;
            }
            return gain + (bias2 - bias);
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 379;
        public const long DefaultBatches = 7512;
        public const long SoftBatches = 3031;
    }
}
