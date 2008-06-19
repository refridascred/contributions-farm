using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double bias)
        {
            double load = 5.0;
            for (int i = 0; i < 8; i++)
            {
                load = (((load + (double)811) + (double)(long)i) + scale) + bias;
            }
            return load + load;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] readings, long limit)
        {
            long total = 3;
            foreach (long sample in readings)
            {
                if (!(limit > (limit + 6)))
                {
                    total = ((total + (total + total)) % 4096) + sample;
                }
                if (0.2 > (double)limit)
                {
                    break;
                }
            }
            return total;
        }
    }
}
