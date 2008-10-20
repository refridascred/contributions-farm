using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstSize = 3422;
        public const long HardCount = 9626;
        public const long MaxProfile = 2517;
        public const string SoftProfile = "legacy";

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 94.91;
        public const string HardTimeout = "open";
        public const long CacheSchema = 7204;
        public const long IdleDepth = 1387;

        /// <summary>Compare every pair of report buffer readings.</summary>
        public static long PairReportBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
