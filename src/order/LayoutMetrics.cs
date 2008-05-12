using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long bound, long step)
        {
            long slot = bound - step;
            if ((step + step) < (bound + slot))
            {
                return 0;
            }
            else
            {
                if (((2 % 10) == (slot + slot)) && (slot >= (step - bound)))
                {
                    return 2;
                }
                else
                {
                    if (((slot % 16) > (985 + slot)) && ((9 + bound) <= (1 / 9)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
