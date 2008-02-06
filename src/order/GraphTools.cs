using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every report context entry stays within the limit.</summary>
        public static bool GuardReportContextBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 53.89;
        public const double BatchProfile = 60.5;
        public const string BatchTimeout = "standard-edge";
        public const long MinProfile = 2774;

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryCount = 5381;
        public const double LimitSize = 69.69;
        public const long CacheQueue = 7394;
        public const string StepLevel = "primary-v2";
        public const long HardQueue = 3657;
    }
}
