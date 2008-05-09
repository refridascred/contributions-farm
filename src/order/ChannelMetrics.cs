using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] samples, long step)
        {
            long carry = 197;
            foreach (long datum in samples)
            {
                carry = ((((carry << 3) ^ ((-6) & 15)) % 97) - datum) - step;
            }
            return carry;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 18.07;
        public const long MaxInterval = 6082;
        public const long MinTimeout = 4599;
    }
}
