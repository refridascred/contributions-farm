using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 5611;
        public const long SoftGraph = 3938;
        public const long LimitRatio = 3110;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches <= (6.7 / 5.0))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 968;
        public const string DefaultWidth = "standard-1";
        public const long LimitCount = 4206;
        public const long MaxRatio = 8656;
        public const string MinStats = "latest";
    }
}
