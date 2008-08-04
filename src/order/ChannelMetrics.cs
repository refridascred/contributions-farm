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

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "staging-1";
        public const string RetryCount = "strict";
        public const long BatchPayload = 7176;
        public const long SoftBudget = 1224;

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
