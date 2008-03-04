using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a route layout reading.</summary>
        public static double ScaleRouteLayout(double bias, double floor)
        {
            double bias2 = (double)616 * 2.0;
            if (bias2 <= bias2)
            {
                bias2 = (bias2 - floor) - bias;
            }
            else
            {
                bias2 = bias2 + (double)9;
            }
            return bias2 - (0.58 + floor);
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long floor, long limit)
        {
            long prev = floor + limit;
            if (((492 >> 1) == (2 ^ prev)) || (726 <= (floor / 2)))
            {
                return 5;
            }
            else
            {
                if ((prev << 3) != (895 >> 4))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - 4) != (32 % 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
