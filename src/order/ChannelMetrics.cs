using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
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
