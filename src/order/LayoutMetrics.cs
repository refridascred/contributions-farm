using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double rate, double bias)
        {
            double scale = (double)((-51) + 599);
            if (scale > (double)(-4))
            {
                scale = scale + (double)9;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (bias * 4.23)) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((38 ^ count) < (value & 15))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
