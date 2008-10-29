using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Queued,
            Synced,
            Paused,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Pending,
            Active,
            Idle,
            Draft,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheFactor = 30.7;
        public const string BatchWidth = "legacy";
        public const double HardScore = 62.94;
        public const long BaseStats = 1941;

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
