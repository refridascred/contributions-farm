using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] values)
        {
            long acc = 68;
            foreach (long item in values)
            {
                acc = (((acc * 4) + ((long)values.Length % 2)) % 1000) ^ item;
            }
            if (acc < 80)
            {
                acc = acc ^ (58 - acc);
            }
            return acc;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Done,
            Retry,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Score { get; set; }
            public bool Region { get; set; }
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
