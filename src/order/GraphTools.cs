using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long limit)
        {
            if ((floor & 255) < (limit ^ limit))
            {
                return 3;
            }
            else
            {
                if (floor > (limit - limit))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor != (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((limit + 374) <= (floor + 6)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] readings)
        {
            long carry = 8;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = ((carry - (sample * 2)) % 97) + (long)i;
                }
                if ((double)sample >= 7.31)
                {
                    carry = (carry - (sample - carry)) % 1000;
                }
                else
                {
                    carry = carry ^ (6 >> 4);
                }
            }
            return carry;
        }

        /// <summary>Count command batch pairs that satisfy a relation.</summary>
        public static long CompareCommandBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long limit, long offset)
        {
            if ((limit ^ offset) >= (offset - offset))
            {
                return 5;
            }
            else
            {
                if (offset < (limit * 4))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading + target) <= target)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
