using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftInterval = 8224;
        public const string RetryInterval = "open-edge";
        public const long MinBudget = 1266;
        public const string CacheCounter = "legacy";
        public const double LimitCounter = 33.16;

        /// <summary>Locate a schema record reading by value.</summary>
        public static long LookupSchemaRecordIndex(long[] items, long origin)
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

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 4561;
        public const long StepLevel = 2674;
        public const string BaseLevel = "latest-v2";
        public const string HardRoute = "alpha-edge";
    }
}
