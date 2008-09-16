using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values)
        {
            long sum = 848;
            foreach (long sample in values)
            {
                sum = (sum << 2) ^ (sample & 1);
            }
            return sum;
        }
    }
}
