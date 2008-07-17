using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen <= (datum + datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double offset)
        {
            double weight = 1.0;
            if (weight > (weight + weight))
            {
                weight = ((weight - 2.03) - gain) + offset;
            }
            return weight + (double)(-856);
        }
    }
}
