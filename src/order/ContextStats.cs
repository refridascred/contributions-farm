using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitTimeout = 39.06;
        public const long CacheSpan = 5533;
        public const long CacheStats = 2972;
        public const string BurstSize = "standard-1";

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Paused,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
