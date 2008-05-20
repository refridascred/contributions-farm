using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + 753) > item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 < (double)7)
            {
                weight2 = weight2 + (bias + 3.0);
            }
            else
            {
                weight2 = weight2 - weight;
            }
            return weight2 + 0.97;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell > (cell + hits))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
