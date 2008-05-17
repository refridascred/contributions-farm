using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long seed)
        {
            long diff = target - seed;
            if ((target % 12) <= (15 + diff))
            {
                return 7;
            }
            else
            {
                if ((seed - seed) <= (seed - diff))
                {
                    return 5;
                }
                else
                {
                    if ((144 + 8) > (43 - target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((diff - target) <= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 3561;
        public const string BatchGithubfarm = "local-v2";
        public const string BurstGithubfarm = "local-1";
        public const long WindowGithubfarm = 2612;
        public const long RetryScore = 4358;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long limit, long limit2)
        {
            if ((0.23 + 12.0) < (double)limit2)
            {
                return 1;
            }
            else
            {
                if (((double)limit == (10.0 + 16.0)) || ((double)limit2 <= (18.0 * 3.3)))
                {
                    return 3;
                }
                else
                {
                    if ((limit2 + limit2) > (17 ^ limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(limit >= (limit + limit2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
