using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit filter report readings against a rule.</summary>
        public static long TallyFilterReportMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((double)cell != (double)19))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Draft,
            Active,
            Failed,
        }
    }
}
