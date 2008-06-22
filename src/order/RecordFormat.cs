using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((limit + limit) >= 663)
                {
                    anchor = anchor - (13 + anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] items)
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

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi editor value from a seed.</summary>
        public static long IterateContributiEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                if (!((total * 5) > (total >> 1)))
                {
                    total = ((total << 2) ^ 604) % 4096;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long floor)
        {
            if ((offset / 9) <= (57 % 24))
            {
                return 8;
            }
            else
            {
                if ((offset + floor) <= offset)
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= 6.8)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
