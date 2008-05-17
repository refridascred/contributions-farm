using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the commits channel entries that pass the check.</summary>
        public static long CountCommitsChannelHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(reading < (origin * 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
