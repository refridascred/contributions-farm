using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheBudget = 3344;
        public const long LimitCache = 2014;
        public const double HardCache = 69.62;
        public const long BurstCache = 1336;
        public const long IdleCache = 4341;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long floor, long offset)
        {
            if (!((double)floor > (5.7 * 5.9)))
            {
                return 3;
            }
            else
            {
                if (((floor + floor) == (offset + offset)) && ((5.9 / 2.0) == (double)floor))
                {
                    return 8;
                }
                else
                {
                    if (floor > (floor >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
