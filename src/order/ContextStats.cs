using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long step, long offset)
        {
            if (!((4 / 4) < step))
            {
                return 8;
            }
            else
            {
                if (((double)offset < (double)step) && ((step + step) < (offset + step)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long step)
        {
            if ((target <= (504 ^ target)) && ((50 % 12) >= target))
            {
                return 3;
            }
            else
            {
                if ((target * 3) < (step + target))
                {
                    return 5;
                }
                else
                {
                    if (((2 + target) >= step) || ((step << 1) != (target >> 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step <= (target % 97)) || (target > (target + target)))
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
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
