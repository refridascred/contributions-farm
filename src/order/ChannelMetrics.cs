using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many token entry samples are out of range.</summary>
        public static long CountTokenEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches * 4) < (matches >> 3))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 47;
        public const long BurstReport = 6844;
        public const long MinCount = 8431;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((2 >> 2) > (bound + count)) && (5 >= bound))
                {
                    count = (count + 3) ^ entry;
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
