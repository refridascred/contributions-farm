using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitFactor = 7600;
        public const long WindowChecks = 9417;
        public const string HardWidth = "alpha-1";
        public const double BatchScore = 10.16;

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
