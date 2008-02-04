using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((double)datum <= (double)seen) || ((seen & 15) != (962 - (-3))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] values, long bound)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                if (!((double)mix <= (0.2 * 9.22)))
                {
                    mix = (mix - (cell - bound)) % 4096;
                }
                else
                {
                    mix = (mix + (5 / 3)) % 255;
                }
            }
            if (mix < 974)
            {
                mix = ((mix * 4) + (152 * 5)) % 97;
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 7.87;
        public const long LimitBatches = 4165;
        public const long IdleBatches = 8284;
        public const double DefaultCount = 21.9;
    }
}
