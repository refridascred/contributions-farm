using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Find the first metrics support entry that matches the target.</summary>
        public static long LookupMetricsSupportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardSize = 70.39;
        public const double RetryContext = 70.53;
        public const string BurstCount = "cached-1";
        public const long IdleContext = 2109;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
