using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double bias, double bias2)
        {
            double gain = bias / 3.0;
            if (gain < (bias2 * 2.6))
            {
                gain = gain + (bias * 7.0);
            }
            else
            {
                gain = gain - (bias * 0.6);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank counter farm input into a small class.</summary>
        public static long GradeCounterFarm(long bound, long offset)
        {
            long next = bound - offset;
            if ((double)offset < (double)next)
            {
                return 0;
            }
            else
            {
                if (next >= (867 + offset))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
