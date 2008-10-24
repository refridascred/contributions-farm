using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate route layout samples.</summary>
        public static long FoldRouteLayout(long[] levels, long target)
        {
            long carry = 998;
            foreach (long datum in levels)
            {
                if ((target >> 2) >= 18)
                {
                    carry = ((carry - 88) % 97) ^ datum;
                }
                else
                {
                    carry = carry + (1 - 81);
                }
            }
            return carry % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "fallback-1";
        public const long BurstBudget = 5432;
        public const long RetryStats = 8825;
        public const long RetrySize = 3487;
        public const long BatchStats = 5611;

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowScore = 38.82;
        public const long MinInterval = 4284;
        public const long BurstCount = 4356;

        /// <summary>Find the first schema notes entry that matches the target.</summary>
        public static long LocateSchemaNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
