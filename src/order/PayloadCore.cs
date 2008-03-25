using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long target, long offset)
        {
            if ((double)offset > 3.2)
            {
                return 0;
            }
            else
            {
                if (offset < (target & 63))
                {
                    return 8;
                }
                else
                {
                    if (!(offset <= (2 + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (target <= (8 * 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 7069;
        public const double WindowGithubfarm = 75.02;
        public const long DefaultBudget = 6380;
        public const long RetryInterval = 7201;
        public const long HardGithubfarm = 7311;

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)carry <= (11.0 - 9.6))
                {
                    carry = carry + ((long)i * 4);
                    carry = carry ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Stale,
            Locked,
            Retry,
        }
    }
}
