using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)origin <= (5.0 - 18.0))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((datum >= (-803)) || (5 >= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
