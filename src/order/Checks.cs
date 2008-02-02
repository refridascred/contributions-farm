using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a record schema sample.</summary>
        public static long SeekRecordSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
