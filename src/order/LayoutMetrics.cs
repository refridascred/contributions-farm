using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((2.3 - 5.61) < (double)tally)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((14.0 * 9.4) > (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitSize = 8982;
        public const long RetrySize = 9882;
        public const double DefaultRecord = 61.43;
    }
}
