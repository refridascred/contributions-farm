using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 2339;
        public const long SoftRecord = 8992;
        public const long SoftRatio = 2660;
        public const string RetryRatio = "alpha";

        /// <summary>Rank layout stream input into a small class.</summary>
        public static long SortLayoutStream(long limit, long bound)
        {
            if (bound < (limit ^ limit))
            {
                return 4;
            }
            else
            {
                if ((double)bound < (6.0 / 8.0))
                {
                    return 6;
                }
                else
                {
                    if (((double)33 != (double)limit) || ((bound * 5) < (5 + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Pending,
            New,
            Idle,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
