using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next session queue value from a seed.</summary>
        public static long RollSessionQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
