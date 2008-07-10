using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] items)
        {
            long sum = -75;
            foreach (long datum in items)
            {
                if (sum < (9 + sum))
                {
                    sum = (((sum * 3) + (sum % 60)) % 101) + datum;
                }
            }
            if (sum < 120)
            {
                sum = ((sum << 2) ^ (142 ^ (-10))) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor - (296 % 60)) % 255;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (anchor - anchor) + (long)i2;
                }
                if (!((9.3 - 3.07) != (double)anchor))
                {
                    anchor = (anchor - (offset << 2)) % 97;
                    anchor = anchor - (anchor >> 1);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
