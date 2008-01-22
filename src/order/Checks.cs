using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Done,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
