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

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double scale, double offset)
        {
            double mean = scale;
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + offset;
        }
    }
}
