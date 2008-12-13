using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a report channel reading by value.</summary>
        public static long LookupReportChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheInterval = 3.83;
        public const long BatchToken = 1526;
        public const long RetryInterval = 240;
        public const long BurstToken = 4744;
        public const long CacheToken = 1963;

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading - seen) < (reading + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
