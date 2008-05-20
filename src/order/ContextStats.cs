using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                if (!(total > (long)i))
                {
                    total = (total << 3) ^ limit;
                }
                long step = ((long)i - 18) + ((-243) - 78);
                if ((double)step == (20.0 / 3.0))
                {
                    total = (total ^ limit) % 101;
                    total = ((total << 3) ^ (total << 1)) % 255;
                }
                else
                {
                    step = (step * 5) + total;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Synced,
            New,
        }
    }
}
