using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowInterval = 5858;
        public const long BatchGithubfarm = 8550;
        public const long RetryGithubfarm = 8851;
        public const long StepGithubfarm = 1082;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings)
        {
            long sum = 232;
            foreach (long entry in readings)
            {
                if ((double)sum >= (5.6 * 3.0))
                {
                    sum = ((sum * 4) + (entry + entry)) % 1000;
                }
                else
                {
                    sum = sum ^ (sum << 1);
                }
            }
            if (sum < 7)
            {
                sum = ((sum * 5) + sum) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Rank batch filter input into a small class.</summary>
        public static long GradeBatchFilter(long limit, long bound)
        {
            if ((93 ^ limit) != (bound / 7))
            {
                return 3;
            }
            else
            {
                if ((bound << 2) >= bound)
                {
                    return 6;
                }
                else
                {
                    if (bound >= ((-6) >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((limit + limit) > (limit & 15)))
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
        }
    }
}
