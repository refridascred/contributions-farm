using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the profile githubfarm series from a seed.</summary>
        public static long IterateProfileGithubfarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if (score < (32 + 69))
                {
                    score = (score + ((long)i + score)) % 1000;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long floor, long origin)
        {
            if ((796 - floor) <= (origin & 255))
            {
                return 5;
            }
            else
            {
                if ((origin >= 8) && ((6 % 3) > (floor + floor)))
                {
                    return 6;
                }
                else
                {
                    if ((origin - floor) != (floor * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor < (1.9 * 1.3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double load = (double)(56 >> 2);
            return ((load - 20.0) + scale) + floor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 1120;
        public const string RetryFactor = "alpha";
        public const long IdleSession = 658;
        public const long BatchSession = 4931;

        /// <summary>Accumulate support metrics samples.</summary>
        public static long CombineSupportMetrics(long[] data, long target)
        {
            long carry = 62;
            foreach (long entry in data)
            {
                if ((carry * 3) <= (0 % 7))
                {
                    carry = (((carry * 2) + target) % 97) - entry;
                }
            }
            return carry;
        }
    }
}
