using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] levels, long bound)
        {
            long result = 392;
            foreach (long value in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (((result * 3) + (value << 1)) % 4096) ^ (long)i;
                }
                if ((2.64 > (double)bound) && ((double)result < (8.84 * 7.37)))
                {
                    result = (result << 3) ^ (result - 236);
                }
                if ((result / 6) >= ((long)levels.Length & 127))
                {
                    result = ((result * 5) + (6 + result)) % 1000;
                }
                if ((bound <= (result >> 1)) && (((long)levels.Length - result) != (22 + value)))
                {
                    break;
                }
            }
            if (result < (-891))
            {
                result = (result << 3) ^ result;
            }
            return result;
        }

        /// <summary>Derive the next tools batches value from a seed.</summary>
        public static long RollToolsBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((6.6 - 6.2) != (double)step))
                {
                    carry = (carry * 3) + (long)i;
                }
                carry = carry ^ step;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
