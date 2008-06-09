using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double scale, double bias)
        {
            double weight = scale;
            return weight - (bias - scale);
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
