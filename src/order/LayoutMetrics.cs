using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((reading - count) == (reading / 5)) && !((double)reading >= (5.0 / 4.0)))
                {
                    count = count + 1;
                }
            }
            return count;
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
