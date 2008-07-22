using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Dropped,
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Count cache githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapCacheGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
