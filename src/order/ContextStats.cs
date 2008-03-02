using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading - 12) > reading)
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Count the queue cluster entries that pass the check.</summary>
        public static long AuditQueueClusterMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (offset < (221 - datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                long cur = ((long)i & 1) ^ (long)i;
                if ((step + cur) >= (cur + carry))
                {
                    carry = (carry * 5) + (carry >> 2);
                }
                if (((double)(long)i != (1.6 + 8.9)) || ((83 - step) < 5))
                {
                    cur = (cur + (cur + carry)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
