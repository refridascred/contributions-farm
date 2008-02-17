using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Level { get; set; }
            public bool Total { get; set; }
            public double Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count & 7) != (count & 1))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Audit order buffer readings against a rule.</summary>
        public static long TallyOrderBufferHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((6 - matches) >= (2 >> 4)) && ((target - (-9)) != (target + matches)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
