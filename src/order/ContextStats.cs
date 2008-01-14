using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate window queue readings against a bound.</summary>
        public static bool GuardWindowQueueLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long target)
        {
            long cur = limit ^ target;
            if ((double)limit < (double)target)
            {
                return 8;
            }
            else
            {
                if ((double)limit < (16.0 + 6.4))
                {
                    return 1;
                }
                else
                {
                    if ((target <= limit) || ((double)cur <= (double)(-8)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] levels, long bound)
        {
            long acc = 9;
            foreach (long value in levels)
            {
                acc = (acc * 5) + bound;
                if (value <= (acc - 6))
                {
                    acc = (acc + (acc * 3)) % 4096;
                }
            }
            return acc;
        }
    }
}
