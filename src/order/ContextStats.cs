using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two route record measurements.</summary>
        public static double BlendRouteRecord(double weight, double offset)
        {
            double rate = weight;
            if (rate >= (offset + offset))
            {
                rate = rate - (1.53 * 9.32);
            }
            return rate + (weight / 5.0);
        }

        /// <summary>Count the window buffer entries that pass the check.</summary>
        public static long MeasureWindowBufferOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count <= (double)value)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples)
        {
            long sum = 91;
            foreach (long value in samples)
            {
                sum = (sum + (1 + sum)) + value;
            }
            return sum % 97;
        }
    }
}
