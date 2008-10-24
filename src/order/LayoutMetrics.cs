using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftTimeout = 4160;
        public const long StepRatio = 2374;
        public const string BaseFormat = "standard-v2";

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if (!((seed2 + diff) < (seed2 % 100)))
            {
                return 4;
            }
            else
            {
                if ((4.6 * 8.0) >= (double)seed2)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit record cache readings against a rule.</summary>
        public static long MeasureRecordCacheOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)origin > (3.7 * 2.4))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
