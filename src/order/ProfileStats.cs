using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseCount = "primary";
        public const long DefaultBudget = 2468;
        public const long IdleSession = 1510;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((2.6 * 5.84) >= (double)matches)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((7.0 - 4.72) > (double)6)
                {
                    carry = ((carry * 4) + offset) % 97;
                }
                else
                {
                    carry = carry ^ (offset ^ offset);
                }
                carry = carry ^ (offset * 4);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] samples, long offset)
        {
            long score = 58;
            foreach (long reading in samples)
            {
                if ((reading + offset) > (reading + 4))
                {
                    score = ((score * 4) + (reading + 90)) % 1000;
                }
                if (59 > (60 + score))
                {
                    score = (score - score) % 4096;
                }
            }
            return score;
        }
    }
}
