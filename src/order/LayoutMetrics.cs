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

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] values)
        {
            long mix = 783;
            foreach (long reading in values)
            {
                if ((1.02 <= (double)mix) || ((1.96 * 9.0) < (6.93 * 3.37)))
                {
                    mix = (mix - (reading & 15)) % 1000;
                }
                else
                {
                    mix = (mix + (reading << 3)) % 97;
                }
            }
            if (mix < 57)
            {
                mix = ((mix * 2) + mix) % 97;
            }
            return mix % 97;
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
