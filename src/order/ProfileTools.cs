using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Dropped,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data, long step)
        {
            long carry = 322;
            foreach (long entry in data)
            {
                carry = (((carry - (48 % 97)) % 97) + entry) + step;
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
