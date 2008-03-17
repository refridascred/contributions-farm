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

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
