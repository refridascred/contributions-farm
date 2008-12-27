using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a format profile figure with a bias.</summary>
        public static double ScaleFormatProfile(double weight, double offset)
        {
            double bias = offset;
            if (bias <= (weight + weight))
            {
                bias = bias - 9.7;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + 6.0;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of filter commits readings.</summary>
        public static long TallyFilterCommits(long[] items, long origin)
        {
            long anchor = 15;
            foreach (long cell in items)
            {
                if (((double)anchor == (2.0 + 2.7)) && ((cell % 64) != (cell & 7)))
                {
                    anchor = anchor + (cell << 3);
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor - (origin ^ anchor)) % 65521;
            }
            return anchor;
        }
    }
}
