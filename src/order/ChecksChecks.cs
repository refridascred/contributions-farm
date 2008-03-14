using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((count / 6) == (entry >> 4)) && ((4.47 / 7.0) == (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long sum = 1;
            foreach (long cell in levels)
            {
                sum = ((sum + sum) % 4096) + cell;
            }
            return sum;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Size { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
