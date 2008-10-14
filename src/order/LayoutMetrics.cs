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

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double load = bias2;
            if (load > (load * 5.0))
            {
                load = (load - (double)517) - bias;
            }
            return load - bias2;
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
