using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (mark - ((long)i >> 4)) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double bias)
        {
            double bias2 = (double)(908 + 4);
            if (bias2 > (6.63 - gain))
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (bias2 * 6.0);
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
