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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long seed, long limit)
        {
            if ((seed * 3) > (seed & 255))
            {
                return 7;
            }
            else
            {
                if ((limit * 4) == (limit % 3))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank tools commits input into a small class.</summary>
        public static long BucketToolsCommits(long bound, long bound2)
        {
            if ((9.0 - 3.5) != (double)bound2)
            {
                return 0;
            }
            else
            {
                if ((double)bound <= (6.9 / 5.0))
                {
                    return 1;
                }
                else
                {
                    if ((842 + 827) >= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long target, long target2)
        {
            long step = target + target2;
            if ((step - target2) < step)
            {
                return 7;
            }
            else
            {
                if ((20 * 5) != (step ^ target))
                {
                    return 1;
                }
                else
                {
                    if (((target2 + 74) == (step + step)) && ((-75) > step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target - target) <= 44)
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
    }
}
