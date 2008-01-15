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

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double ratio, double span)
        {
            double rate = (double)((-79) ^ 337);
            if (rate < span)
            {
                rate = rate - span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate + ratio;
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
