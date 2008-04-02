using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] levels)
        {
            long state = 26;
            foreach (long cell in levels)
            {
                if (((state * 3) < (state ^ 313)) && ((double)13 < (double)state))
                {
                    state = ((state * 3) + 15) ^ cell;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            New,
            Stale,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] values, long limit)
        {
            long carry = 806;
            foreach (long sample in values)
            {
                if ((limit ^ carry) != (limit & 31))
                {
                    carry = (((carry << 3) ^ carry) % 101) ^ sample;
                }
            }
            return carry;
        }
    }
}
