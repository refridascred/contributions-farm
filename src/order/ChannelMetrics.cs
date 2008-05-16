using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Locked,
            New,
            Retry,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry / 5) <= (seed >> 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
