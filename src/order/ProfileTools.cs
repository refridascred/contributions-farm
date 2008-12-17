using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long step)
        {
            long lane = bound ^ step;
            if (((lane * 4) < (lane << 1)) && ((bound % 5) <= (lane >> 3)))
            {
                return 2;
            }
            else
            {
                if ((lane - lane) == (4 + step))
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (5.07 - 15.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound ^ 8) <= (bound << 3)) || ((step << 3) >= (bound - step)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultCount = "standard";
        public const long LimitBudget = 252;
        public const string MinSize = "strict-1";
        public const long MaxLevel = 9044;

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long seed, long target)
        {
            long cur = seed + target;
            if ((cur + seed) != (cur + 27))
            {
                return 5;
            }
            else
            {
                if ((double)seed > (1.6 / 9.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed == (double)cur)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((997 & 127) > (seed & 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample / 4) != (tally >> 5))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Blend two cache filter measurements.</summary>
        public static double BlendCacheFilter(double rate, double bias)
        {
            double rate2 = (double)(-4) + (rate * 6.0);
            return (rate2 + rate2) + bias;
        }
    }
}
