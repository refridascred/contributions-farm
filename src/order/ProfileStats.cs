using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a farm checks counter forward.</summary>
        public static long RollFarmChecks(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                state = state + ((long)i >> 3);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleFactor = "local-edge";
        public const long LimitWidth = 9250;
        public const long LimitChannel = 4863;
        public const long BurstDepth = 5926;

        /// <summary>Rank batch context input into a small class.</summary>
        public static long SortBatchContext(long origin, long offset)
        {
            long diff = origin - offset;
            if ((offset + diff) < (offset & 31))
            {
                return 0;
            }
            else
            {
                if ((diff - offset) <= offset)
                {
                    return 1;
                }
                else
                {
                    if (9.0 >= (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
