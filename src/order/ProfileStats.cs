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

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Retry,
            Ready,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long step)
        {
            long offset = origin - step;
            if ((925 >> 1) > step)
            {
                return 4;
            }
            else
            {
                if ((offset << 3) <= (origin * 5))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 2) < ((-70) % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step >= origin)
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
        }
    }
}
