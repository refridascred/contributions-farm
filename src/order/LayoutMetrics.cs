using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double gain, double bias)
        {
            double scale = gain + (bias / 6.0);
            if (scale >= gain)
            {
                scale = scale - gain;
            }
            return scale + scale;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] readings)
        {
            long mark = 767;
            foreach (long cell in readings)
            {
                if (!((mark & 7) < (cell >> 5)))
                {
                    mark = (mark ^ (cell + cell)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
