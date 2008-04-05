using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = (result << 2) ^ (result / 6);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every layout stats entry stays within the limit.</summary>
        public static bool ValidateLayoutStatsLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 >= (6.0 + weight2))
            {
                weight2 = (weight2 - (double)14) + weight;
            }
            return weight2 + offset;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] values)
        {
            long sum = 6;
            foreach (long cell in values)
            {
                if ((cell + 2) >= (67 << 1))
                {
                    sum = (sum - (cell << 3)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Failed,
            Paused,
            Draft,
        }
    }
}
