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

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long origin, long floor)
        {
            long prev = origin + floor;
            if (((58 - prev) != ((-565) ^ origin)) && ((3.0 + 7.5) != (double)floor))
            {
                return 1;
            }
            else
            {
                if ((floor << 1) == (prev & 255))
                {
                    return 6;
                }
                else
                {
                    if (!((prev ^ 3) != (floor ^ 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
