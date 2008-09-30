using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor ^ (target << 3);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Pending,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 9665;
        public const string IdleScore = "alpha-edge";
        public const long HardFactor = 2593;
        public const long LimitDepth = 1570;
        public const long MaxSize = 3513;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long floor, long limit)
        {
            if ((double)limit >= (double)floor)
            {
                return 4;
            }
            else
            {
                if ((limit + limit) >= (floor << 3))
                {
                    return 3;
                }
                else
                {
                    if ((floor + limit) >= limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)floor <= (9.12 / 5.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
