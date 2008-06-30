using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample <= tally) || (((tally + sample) == (tally >> 1)) && ((977 + sample) == (tally * 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstMetric = "staging-edge";
        public const long DefaultMetric = 699;
        public const long MinSpan = 9314;
    }
}
