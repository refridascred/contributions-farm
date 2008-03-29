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

        /// <summary>Iterate the tools support series from a seed.</summary>
        public static long SeriesToolsSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
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
