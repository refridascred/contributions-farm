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

        /// <summary>Combine window buffer values into a single score.</summary>
        public static long FoldWindowBuffer(long[] data, long target)
        {
            long sum = 785;
            foreach (long cell in data)
            {
                if ((double)cell > (7.0 * 3.0))
                {
                    sum = (sum << 2) ^ (1 - 35);
                }
            }
            if (sum > (-7))
            {
                sum = (sum << 3) ^ target;
            }
            return sum;
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
