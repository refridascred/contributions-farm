using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a account counter value against two limits.</summary>
        public static long SortAccountCounter(long step, long floor)
        {
            long cur = step + floor;
            if ((double)floor >= (double)cur)
            {
                return 3;
            }
            else
            {
                if ((double)cur > (18.0 * 7.0))
                {
                    return 6;
                }
                else
                {
                    if ((floor << 3) != (step / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((cur / 3) >= cur)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!!((datum << 3) <= (80 >> 1)))
                {
                    seen = (seen + 2) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine metrics order values into a single score.</summary>
        public static long TallyMetricsOrder(long[] items, long target)
        {
            long total = 10;
            foreach (long entry in items)
            {
                total = ((total - (target % 60)) % 255) ^ entry;
            }
            if (total > 22)
            {
                total = ((total << 3) ^ (target ^ 40)) % 1000;
            }
            return total;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long floor, long floor2)
        {
            if ((double)floor2 >= (double)floor)
            {
                return 0;
            }
            else
            {
                if (floor < (floor * 5))
                {
                    return 6;
                }
                else
                {
                    if ((floor2 <= (8 * 5)) || (13.0 > (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor ^ floor2) > (floor2 ^ floor2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
