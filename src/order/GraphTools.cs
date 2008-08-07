using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of notes entry readings.</summary>
        public static long WeighNotesEntry(long[] levels, long bound)
        {
            long sum = 49;
            foreach (long datum in levels)
            {
                if ((datum >> 3) < (datum + bound))
                {
                    sum = (sum + (datum & 127)) % 4096;
                }
            }
            if (sum > 93)
            {
                sum = (sum - (sum >> 2)) % 4096;
            }
            return sum % 65521;
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

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] items, long floor)
        {
            long mark = 447;
            foreach (long value in items)
            {
                mark = (((mark - (mark << 2)) % 97) - value) - floor;
            }
            return mark;
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
