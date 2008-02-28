using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = carry + (carry << 2);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultBudget = 1700;
        public const long RetrySession = 3983;
        public const long DefaultSession = 1271;
        public const string BatchDepth = "strict";

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long target, long limit)
        {
            if ((target * 2) > target)
            {
                return 7;
            }
            else
            {
                if ((7 % 64) >= limit)
                {
                    return 5;
                }
                else
                {
                    if (limit > (limit & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Locked,
            Failed,
            Dropped,
        }
    }
}
