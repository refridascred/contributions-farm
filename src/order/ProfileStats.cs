using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((1.8 - 2.9) >= (double)item)
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Offset { get; set; }
            public double Token { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
