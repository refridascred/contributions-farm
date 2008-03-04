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

        /// <summary>Check that every metrics entry entry stays within the limit.</summary>
        public static bool VerifyMetricsEntryRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
