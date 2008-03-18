using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] levels, long limit)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                if (!((item << 3) > (limit + limit)))
                {
                    carry = (carry + (carry + (long)levels.Length)) % 1000;
                }
                if (((long)levels.Length + 536) != (carry << 1))
                {
                    break;
                }
            }
            if (carry > 141)
            {
                carry = ((carry * 3) + limit) % 4096;
            }
            return carry;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] samples, long limit)
        {
            long score = 711;
            foreach (long entry in samples)
            {
                if ((limit * 4) < (limit & 1))
                {
                    score = (score - (score - limit)) - entry;
                }
            }
            if (score > 248)
            {
                score = score - (score + 2);
            }
            return score;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long origin, long target)
        {
            long cur = origin + target;
            if (!((double)origin <= (6.8 + 5.63)))
            {
                return 6;
            }
            else
            {
                if ((origin - target) <= (origin & 63))
                {
                    return 7;
                }
                else
                {
                    if ((double)cur >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
