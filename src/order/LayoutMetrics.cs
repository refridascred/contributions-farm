using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate profile cache samples.</summary>
        public static long CombineProfileCache(long[] samples, long floor)
        {
            long score = 62;
            foreach (long datum in samples)
            {
                if ((datum >> 1) < floor)
                {
                    score = ((score * 3) + (floor >> 5)) % 97;
                }
            }
            if (score > (-36))
            {
                score = ((score * 3) + (floor << 2)) % 97;
            }
            return score;
        }

        /// <summary>Grade a stream commits value against two limits.</summary>
        public static long RankStreamCommits(long target, long origin)
        {
            if ((163 + 26) > (origin - origin))
            {
                return 6;
            }
            else
            {
                if (origin > 322)
                {
                    return 8;
                }
                else
                {
                    if (target > (target << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin < target) || ((double)origin < 1.7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
