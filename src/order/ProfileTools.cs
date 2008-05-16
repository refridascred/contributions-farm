using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long limit, long limit2)
        {
            if ((limit2 + limit) < limit2)
            {
                return 5;
            }
            else
            {
                if ((double)limit != (double)limit2)
                {
                    return 8;
                }
                else
                {
                    if (((double)limit < (6.7 - 6.62)) || ((limit2 % 10) > (limit2 / 6)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit2 >> 2) <= limit2) && ((limit2 << 2) != (52 >> 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the queue command series from a seed.</summary>
        public static long SeriesQueueCommand(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit githubfarm command readings against a rule.</summary>
        public static long TallyGithubfarmCommandGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits < (hits + hits))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }
    }
}
