using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate window stats readings against a bound.</summary>
        public static bool VerifyWindowStatsRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i > state)
                {
                    long slot = seed + (long)i;
                    state = state + (slot * 4);
                }
                if (((seed * 5) > state) || ((double)state == (8.4 - 1.7)))
                {
                    long count = state - (seed * 5);
                    state = ((state << 2) ^ count) % 1000;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long target, long floor)
        {
            long span = target ^ floor;
            if ((floor % 8) < (target << 1))
            {
                return 3;
            }
            else
            {
                if (span <= (8 - floor))
                {
                    return 0;
                }
                else
                {
                    if ((double)span >= (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
