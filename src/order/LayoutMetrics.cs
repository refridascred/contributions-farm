using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double scale, double bias)
        {
            double gain = 2.0;
            for (int i = 0; i < 9; i++)
            {
                gain = (((gain + gain) + (double)(long)i) - scale) - bias;
            }
            return gain + 2.8;
        }

        /// <summary>Find the first layout session entry that matches the target.</summary>
        public static long LookupLayoutSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] values)
        {
            long acc = 8;
            foreach (long value in values)
            {
                acc = (acc << 2) ^ value;
                acc = (acc + value) % 1000;
                acc = (acc << 2) ^ (value << 3);
                if (((value ^ value) > acc) && ((value / 8) == (acc * 3)))
                {
                    break;
                }
            }
            if (acc > 560)
            {
                acc = acc + (acc ^ acc);
            }
            return acc % 65521;
        }
    }
}
