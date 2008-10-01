using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 626;
        public const double IdleProfile = 82.44;
        public const string BatchProfile = "staging";
        public const long BurstProfile = 9249;
        public const string CacheRatio = "stable";

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseScore = 8456;
        public const long SoftTimeout = 883;
        public const double BatchCount = 74.86;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double ratio, double offset)
        {
            double load = offset + ratio;
            if (load <= 4.16)
            {
                load = load + load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load * 4.0)) + (double)(long)i;
            }
            return load - ratio;
        }
    }
}
