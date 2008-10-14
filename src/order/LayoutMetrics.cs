using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double rate, double floor)
        {
            double bias = rate;
            if (bias <= floor)
            {
                bias = bias - (rate / 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (bias - rate)) + (double)(long)i;
            }
            return bias + rate;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long target, long target2)
        {
            if (896 > (target - target))
            {
                return 6;
            }
            else
            {
                if ((target2 << 1) <= (target - target))
                {
                    return 3;
                }
                else
                {
                    if (target > target2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
