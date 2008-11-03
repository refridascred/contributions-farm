using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels, long step)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                if ((acc > 593) || ((acc + item) < 46))
                {
                    acc = ((acc - item) % 1000) - step;
                }
                else
                {
                    acc = ((acc << 2) ^ (long)levels.Length) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Failed,
            Retry,
            Draft,
        }
    }
}
