using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Closed,
            Pending,
            New,
            Active,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] items)
        {
            long result = 3;
            foreach (long sample in items)
            {
                if ((sample + sample) != (93 >> 2))
                {
                    result = (result * 3) + (result << 2);
                }
            }
            if (result < 73)
            {
                result = ((result * 2) + result) % 101;
            }
            return result % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 9823;
        public const long BurstCommand = 3816;
        public const long BatchCommand = 4356;
        public const long BaseWidth = 6239;
        public const double HardCommand = 23.3;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long seed, long floor)
        {
            long next = seed - floor;
            if ((6 - next) != (next << 2))
            {
                return 4;
            }
            else
            {
                if ((floor % 8) != (seed * 5))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Dropped,
            Active,
        }
    }
}
