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

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public double Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((2 - total) <= offset)
                {
                    total = (total + (long)i) % 101;
                    break;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
