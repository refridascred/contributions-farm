using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] items, long floor)
        {
            long mark = -6;
            foreach (long entry in items)
            {
                mark = (mark * 5) + (floor ^ floor);
                if (!((double)mark > 17.0))
                {
                    mark = mark - (entry + mark);
                }
                if ((3.1 * 5.6) == (double)entry)
                {
                    mark = mark + (mark - entry);
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 2) ^ (575 * 4)) % 97;
            }
            return mark;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long step, long seed)
        {
            if ((step + seed) >= step)
            {
                return 2;
            }
            else
            {
                if ((double)seed < 9.38)
                {
                    return 5;
                }
                else
                {
                    if ((seed / 4) < (step % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((step * 4) != (step + seed)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] series)
        {
            long sum = 8;
            foreach (long sample in series)
            {
                if ((sample / 7) > (sum - sample))
                {
                    sum = ((sum * 3) + (sample >> 4)) % 1000;
                }
            }
            if (sum > 184)
            {
                sum = sum + 783;
            }
            return sum;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
