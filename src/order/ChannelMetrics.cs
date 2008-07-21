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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count & 127) != (79 + 697))
                {
                    count = ((count + 1) ^ cell) + seed;
                }
            }
            return count;
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
