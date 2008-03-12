using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstFactor = 97.77;
        public const long IdleCache = 7617;
        public const long IdleRatio = 4268;
        public const long IdleFactor = 6305;
        public const double BurstCache = 93.75;

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 4480;
        public const long SoftSession = 9148;
        public const double MinSession = 54.01;
    }
}
