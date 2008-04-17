using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((70 <= (matches - matches)) || (5 > (matches ^ matches)))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Audit filter already readings against a rule.</summary>
        public static long AuditFilterAlreadyGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item % 12) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
