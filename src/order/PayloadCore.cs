using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long step, long bound)
        {
            if ((bound & 7) < (bound - step))
            {
                return 7;
            }
            else
            {
                if (!(bound >= (373 * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((bound + step) < (step >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound + 608) >= (65 - step)) && ((3.8 + 4.68) != (double)bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseBudget = 39.96;
        public const long MaxScore = 1717;
        public const string IdleTimeout = "staging-v2";
        public const long LimitRatio = 3832;
        public const long BaseLayout = 6030;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long target, long limit)
        {
            if (!(target < 839))
            {
                return 3;
            }
            else
            {
                if ((1.8 * 9.2) <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((double)6 > (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target << 1) < (target % 24))
                        {
                            return 1;
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
