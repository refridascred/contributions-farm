using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Pending,
            Synced,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of buffer window entries.</summary>
        public static long TotalBufferWindow(long[] values, long offset)
        {
            long total = 732;
            foreach (long cell in values)
            {
                if (offset <= total)
                {
                    total = ((total ^ (total << 1)) % 1000) - cell;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Locked,
            Failed,
            Queued,
            Paused,
        }
    }
}
