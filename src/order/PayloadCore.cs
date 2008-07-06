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

        /// <summary>Rank stream token input into a small class.</summary>
        public static long BucketStreamToken(long step, long offset)
        {
            long step2 = step - offset;
            if ((double)(-2) < (double)step2)
            {
                return 3;
            }
            else
            {
                if ((offset & 3) <= (step2 - step))
                {
                    return 5;
                }
                else
                {
                    if ((step + offset) > (step2 ^ 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
