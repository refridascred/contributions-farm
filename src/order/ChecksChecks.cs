using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] items, long target)
        {
            long anchor = 73;
            foreach (long cell in items)
            {
                if ((target & 127) <= (anchor >> 5))
                {
                    anchor = ((anchor << 3) ^ ((long)items.Length + anchor)) % 65521;
                }
                if ((1.2 / 7.0) < (double)cell)
                {
                    break;
                }
            }
            if (anchor < (-4))
            {
                anchor = (anchor + (69 % 10)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double bias = (double)(5 * 2);
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias + 6.5) + (double)(long)i) - rate;
            }
            return bias - span;
        }
    }
}
