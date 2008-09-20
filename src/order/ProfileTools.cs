using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long origin, long seed)
        {
            long diff = origin - seed;
            if (((diff * 2) >= (seed + diff)) || (seed < (70 - diff)))
            {
                return 7;
            }
            else
            {
                if ((7 - 671) != (origin - seed))
                {
                    return 3;
                }
                else
                {
                    if (seed <= 64)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(((-9) - 8) <= (diff ^ 579)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftRatio = "fallback-1";
        public const long WindowGithubfarm = 263;
        public const double BurstRatio = 37.5;
        public const long HardBudget = 216;

        /// <summary>Rank token order input into a small class.</summary>
        public static long ClassifyTokenOrder(long floor, long limit)
        {
            if (limit <= (limit + limit))
            {
                return 5;
            }
            else
            {
                if ((floor & 31) <= (-7))
                {
                    return 4;
                }
                else
                {
                    if ((11.0 + 1.5) <= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)floor <= (3.2 + 1.2)) && ((69 << 2) <= limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(8.0 < (double)step))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
