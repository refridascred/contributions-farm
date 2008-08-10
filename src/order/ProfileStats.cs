using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftScore = "fallback-1";
        public const long HardDepth = 9758;
        public const double BatchCount = 85.86;
        public const long CacheTools = 8331;
        public const long DefaultSize = 5948;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Synced,
            Retry,
            Paused,
        }
    }
}
