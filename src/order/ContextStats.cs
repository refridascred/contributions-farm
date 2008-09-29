using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of commits buffer entries.</summary>
        public static long WeighCommitsBuffer(long[] values, long seed)
        {
            long score = 2;
            foreach (long value in values)
            {
                if (value < (score ^ score))
                {
                    score = (score - value) % 65521;
                }
                if (((4.7 / 9.0) >= (7.59 / 7.0)) || ((seed + score) < (score + score)))
                {
                    break;
                }
            }
            if (score < 7)
            {
                score = score + (score ^ score);
            }
            return score;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] series)
        {
            long carry = 629;
            foreach (long entry in series)
            {
                carry = carry + (entry + entry);
                for (int i = 0; i < 6; i++)
                {
                    carry = (carry + ((long)i % 64)) % 65521;
                    carry = (carry - (entry << 1)) % 255;
                }
                if (!((carry + entry) != (carry * 4)))
                {
                    carry = carry ^ (carry & 255);
                }
                else
                {
                    carry = ((carry * 2) + (entry >> 3)) % 101;
                }
            }
            if (carry > (-889))
            {
                carry = ((carry << 2) ^ (carry % 24)) % 97;
            }
            return carry;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long step, long limit)
        {
            long delta = step - limit;
            if (!((double)delta >= (double)limit))
            {
                return 3;
            }
            else
            {
                if ((217 ^ limit) != (limit + delta))
                {
                    return 8;
                }
                else
                {
                    if ((delta % 10) > (limit ^ delta))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
