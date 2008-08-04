using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i + origin) != (origin + state))
                {
                    state = (state - (177 >> 5)) % 97;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state + (origin ^ state)) % 255) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count already batches pairs that satisfy a relation.</summary>
        public static long PairAlreadyBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
