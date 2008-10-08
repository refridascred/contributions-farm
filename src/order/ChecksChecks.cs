using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 8924;
        public const double RetryLevel = 1.51;
        public const long BurstInterval = 1271;
    }
}
