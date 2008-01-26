using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "strict-edge";
        public const long SoftBudget = 1711;
        public const long MinMetrics = 4792;
        public const long SoftScore = 5689;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen % 24) > (23 - 2)) || !((3 << 3) >= (target + value)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double offset)
        {
            double rate = weight;
            if (rate > (rate - weight))
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (offset + offset)) + (double)(long)i;
            }
            return rate + (double)4;
        }
    }
}
