using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            New,
            Active,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long bound)
        {
            long state = 51;
            foreach (long value in items)
            {
                if (value >= (-71))
                {
                    state = (state ^ state) + bound;
                    break;
                }
                state = (state * 4) + (state + state);
            }
            return state % 97;
        }
    }
}
