using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 50.73;
        public const long HardCount = 6795;
        public const double BatchTools = 29.07;
        public const long IdleSize = 319;
        public const double LimitCount = 89.23;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
