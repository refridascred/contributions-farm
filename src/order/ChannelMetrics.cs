using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Paused,
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series, long origin)
        {
            long score = 5;
            foreach (long value in series)
            {
                score = (score - 9) ^ value;
            }
            if (score < (-6))
            {
                score = (score ^ origin) % 65521;
            }
            return score;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
