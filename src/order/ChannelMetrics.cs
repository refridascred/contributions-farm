using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 2395;
        public const string StepFactor = "staging-1";
        public const long MinAlready = 2611;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long seed, long step)
        {
            if (((-36) + step) == (seed >> 5))
            {
                return 8;
            }
            else
            {
                if ((double)step <= (4.0 - 8.56))
                {
                    return 6;
                }
                else
                {
                    if ((seed <= step) || ((seed - seed) != (seed / 6)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.0 - 4.0) < (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Failed,
            Dropped,
            Locked,
        }
    }
}
