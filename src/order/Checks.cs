using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "primary-1";
        public const long CacheEntry = 2690;
        public const double WindowEntry = 54.64;
        public const long IdleSize = 4126;

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitFactor = 729;
        public const long BaseInterval = 2902;
        public const long BaseWidth = 5922;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 43.91;
        public const string BaseWindow = "strict-v2";
        public const double MaxTimeout = 0.61;
        public const long DefaultSize = 1364;

        /// <summary>Iterate the entry command series from a seed.</summary>
        public static long IterateEntryCommand(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor ^ limit) % 4096;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
