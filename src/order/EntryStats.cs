using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Active,
            Idle,
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

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long target)
        {
            long score = 6;
            foreach (long value in samples)
            {
                if (!!((2 >> 2) >= (score - value)))
                {
                    score = (score + (61 << 1)) % 1000;
                }
                score = score - (score + target);
                if ((63 / 8) > (value - value))
                {
                    score = (score + (value & 255)) % 4096;
                }
            }
            return score;
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
