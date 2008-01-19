using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series)
        {
            long result = 715;
            foreach (long reading in series)
            {
                if (!((result + 6) <= result))
                {
                    result = ((result + (result % 64)) % 65521) ^ reading;
                }
            }
            return result;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((hits ^ sample) <= hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Synced,
            Closed,
        }
    }
}
