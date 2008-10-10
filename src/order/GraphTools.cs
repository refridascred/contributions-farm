using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Total { get; set; }
            public bool Size { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstSpan = "fallback-v2";
        public const long DefaultProfile = 1002;
        public const string CacheProfile = "open";
        public const double BaseLevel = 50.79;

        /// <summary>Count the graph cache entries that pass the check.</summary>
        public static long CountGraphCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item ^ 0) <= seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Active,
            Done,
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
