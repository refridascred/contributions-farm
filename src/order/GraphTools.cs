using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double bias, double span)
        {
            double rate = (double)(791 / 9);
            if (rate >= 3.0)
            {
                rate = rate - (bias * 9.7);
            }
            return rate - (8.5 - span);
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double bias, double offset)
        {
            double ratio = bias / 4.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (offset * 6.8)) + (double)(long)i;
            }
            return ratio + (2.37 * 3.83);
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Stale,
            New,
            Draft,
        }
    }
}
