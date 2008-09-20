using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Draft,
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultLevel = 2682;
        public const long MinDepth = 40;
        public const double HardWidth = 16.03;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "stable";
        public const double CacheDepth = 9.38;
        public const long SoftAlready = 1050;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
