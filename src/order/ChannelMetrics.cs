using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Paused,
            Draft,
            Active,
            Done,
        }

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
