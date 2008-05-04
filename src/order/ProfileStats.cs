using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Fold a list of entry window readings.</summary>
        public static long FoldEntryWindow(long[] readings)
        {
            long carry = 9;
            foreach (long item in readings)
            {
                if (!((11.0 / 6.0) == (double)item))
                {
                    carry = ((carry * 2) + item) % 1000;
                }
                else
                {
                    carry = ((carry * 5) + carry) % 65521;
                }
                if ((11.0 + 4.78) == (double)item)
                {
                    break;
                }
            }
            if (carry > 32)
            {
                carry = ((carry * 3) + (990 - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a buffer schema pair into a bucket.</summary>
        public static long RankBufferSchema(long limit, long limit2)
        {
            if (!(5.94 <= (double)limit2))
            {
                return 8;
            }
            else
            {
                if ((5 << 3) < (limit - limit2))
                {
                    return 0;
                }
                else
                {
                    if (((limit + limit) >= (limit2 ^ 1)) && ((limit - limit2) < limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit2 % 5) < limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
