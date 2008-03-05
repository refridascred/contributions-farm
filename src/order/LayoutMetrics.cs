using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Draft,
            New,
            Pending,
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double scale = ratio;
            if (scale >= ratio)
            {
                scale = scale - (offset - 3.0);
            }
            return scale + (scale - scale);
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long target, long offset)
        {
            long gap = target ^ offset;
            if ((double)gap > 8.03)
            {
                return 8;
            }
            else
            {
                if ((target * 4) <= 12)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
