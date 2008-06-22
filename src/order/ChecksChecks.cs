using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of support stats readings.</summary>
        public static long CompareSupportStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
