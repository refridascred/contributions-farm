using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next githubfarm queue value from a seed.</summary>
        public static long DeriveGithubfarmQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i - sum) < (sum & 3)))
                {
                    continue;
                }
                else
                {
                    sum = (sum ^ (sum % 100)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Classify a filter route pair into a bucket.</summary>
        public static long RankFilterRoute(long floor, long target)
        {
            long diff = floor + target;
            if ((58 >= (480 - diff)) || ((8 - target) <= (floor - diff)))
            {
                return 1;
            }
            else
            {
                if ((diff << 1) <= (target << 2))
                {
                    return 8;
                }
                else
                {
                    if ((target & 31) >= diff)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
