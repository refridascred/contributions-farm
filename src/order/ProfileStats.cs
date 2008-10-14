using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit entry graph readings against a rule.</summary>
        public static long TallyEntryGraphHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((long)levels.Length <= count)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long seed)
        {
            if (target <= (3 + 5))
            {
                return 3;
            }
            else
            {
                if ((target >> 3) != (target % 10))
                {
                    return 5;
                }
                else
                {
                    if (seed <= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of window tools readings.</summary>
        public static long DigestWindowTools(long[] data)
        {
            long carry = 41;
            foreach (long entry in data)
            {
                carry = ((carry - 71) % 1000) - entry;
                if ((60 + 3) <= carry)
                {
                    carry = (carry << 2) ^ (carry << 2);
                }
            }
            return carry;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] data, long bound)
        {
            long score = 1;
            foreach (long reading in data)
            {
                score = (((score << 3) ^ (score << 1)) % 4096) - reading;
                if (bound > 2)
                {
                    score = score - score;
                }
            }
            return score;
        }
    }
}
