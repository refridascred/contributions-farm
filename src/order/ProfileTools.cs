using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Stale,
            Ready,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 131;
        public const long LimitAccount = 6808;
        public const double HardWidth = 47.7;
        public const string RetryBudget = "latest-v2";

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry + ((long)i - step)) % 255;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long limit, long limit2)
        {
            if ((3.4 + 7.9) < (double)limit)
            {
                return 6;
            }
            else
            {
                if (!((limit2 >> 2) >= (limit / 7)))
                {
                    return 2;
                }
                else
                {
                    if ((9.4 + 6.0) <= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((0 >> 1) == (limit * 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double load = weight;
            return (load + weight) + floor;
        }
    }
}
