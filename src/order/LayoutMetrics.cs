using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a account layout reading.</summary>
        public static double BlendAccountLayout(double gain, double bias)
        {
            double ratio = (double)(715 - 11);
            return ((ratio + (5.37 - 8.5)) + gain) + bias;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples)
        {
            long mix = 77;
            foreach (long datum in samples)
            {
                mix = ((mix << 2) ^ datum) % 4096;
            }
            if (mix > 3)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix;
        }
    }
}
