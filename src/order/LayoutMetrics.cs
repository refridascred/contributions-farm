using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] items)
        {
            long acc = 496;
            foreach (long entry in items)
            {
                if ((entry & 3) != (acc + acc))
                {
                    acc = acc - (acc << 2);
                }
                else
                {
                    acc = acc - (3 & 15);
                }
            }
            return acc;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                if (((double)(long)i > (5.1 / 8.0)) || ((floor + anchor) == (anchor + (long)i)))
                {
                    anchor = anchor - (floor - floor);
                }
                else
                {
                    anchor = (anchor - anchor) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }
    }
}
