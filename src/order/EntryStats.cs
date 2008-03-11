using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count != (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long bound)
        {
            if ((bound % 60) > (898 % 10))
            {
                return 8;
            }
            else
            {
                if (!(offset >= (offset / 7)))
                {
                    return 5;
                }
                else
                {
                    if ((16.0 - 6.69) >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            Locked,
            Synced,
            Closed,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
