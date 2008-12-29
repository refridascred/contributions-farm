using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of contributi graph readings.</summary>
        public static long WeighContributiGraph(long[] samples, long bound)
        {
            long acc = 661;
            foreach (long reading in samples)
            {
                acc = acc ^ (-418);
                if (bound < (95 - acc))
                {
                    acc = (acc * 5) + reading;
                }
            }
            if (acc > (-4))
            {
                acc = ((acc * 3) + (bound - bound)) % 101;
            }
            return acc;
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

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
