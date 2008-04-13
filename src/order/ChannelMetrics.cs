using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 3004;
        public const long SoftSpan = 2737;
        public const long IdleInterval = 5873;
        public const string IdleScore = "cached";
        public const double HardStream = 1.83;
    }
}
