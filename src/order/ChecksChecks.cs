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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitWidth = 3.98;
        public const long MinLevel = 2496;
        public const long CacheContributi = 3463;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Synced,
            Retry,
        }
    }
}
