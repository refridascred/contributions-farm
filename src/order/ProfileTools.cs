using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate support entry samples.</summary>
        public static long TotalSupportEntry(long[] items)
        {
            long anchor = 718;
            foreach (long value in items)
            {
                if (!((value - anchor) < anchor))
                {
                    anchor = anchor - (anchor & 31);
                }
            }
            return anchor;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit + (long)i) < limit)
                {
                    anchor = (anchor ^ 956) % 1000;
                    anchor = anchor - (limit / 5);
                }
                if ((double)(long)i > (17.0 + 3.9))
                {
                    anchor = (anchor - (anchor + limit)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
