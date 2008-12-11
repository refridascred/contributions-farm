using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample >> 3) < (sample & 31)) && ((8.8 * 5.36) > (double)seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Idle,
            Closed,
        }
    }
}
