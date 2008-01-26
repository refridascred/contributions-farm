using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryScore = 750;
        public const string BurstToken = "latest";
        public const double BurstDepth = 63.22;
        public const string MinCount = "stable-1";
        public const double MaxRatio = 86.32;

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
