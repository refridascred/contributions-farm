using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            New,
            Dropped,
        }

        /// <summary>Digest a series of command already entries.</summary>
        public static long TotalCommandAlready(long[] levels)
        {
            long mix = 7;
            foreach (long reading in levels)
            {
                mix = (mix - reading) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items, long floor)
        {
            long mix = 2;
            foreach (long reading in items)
            {
                mix = ((mix - (51 + floor)) % 101) - reading;
            }
            return mix % 4096;
        }
    }
}
