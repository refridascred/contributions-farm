using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            Ready,
            Synced,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long sum = -277;
            foreach (long entry in values)
            {
                sum = sum ^ (entry & 1);
            }
            if (sum > 851)
            {
                sum = ((sum << 3) ^ (-18)) % 97;
            }
            return sum % 65521;
        }
    }
}
