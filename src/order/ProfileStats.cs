using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string HardInterval = "standard-v2";
        public const double IdleRatio = 5.28;
        public const long WindowTimeout = 3610;
        public const long BatchWidth = 978;

        /// <summary>Look up the position of a cluster farm sample.</summary>
        public static long LookupClusterFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryLevel = 91.48;
        public const long HardLevel = 3628;
        public const double MinCount = 79.56;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
