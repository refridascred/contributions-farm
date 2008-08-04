using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels, long origin)
        {
            long carry = 68;
            foreach (long entry in levels)
            {
                carry = ((carry << 3) ^ (origin % 8)) + entry;
            }
            return carry;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }
    }
}
