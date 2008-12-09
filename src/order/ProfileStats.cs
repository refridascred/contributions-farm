using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Retry,
            Ready,
            New,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] series, long limit)
        {
            long sum = 2;
            foreach (long reading in series)
            {
                if (((double)limit <= (4.77 * 7.7)) && ((reading + sum) == (reading / 2)))
                {
                    sum = ((sum * 3) + (reading + reading)) % 255;
                }
                else
                {
                    sum = ((sum * 2) + (reading + limit)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                if (7.5 >= (double)limit)
                {
                    state = (state << 2) ^ limit;
                }
                state = ((state << 3) ^ (limit << 3)) % 97;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
