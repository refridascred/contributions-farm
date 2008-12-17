using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((2.15 * 8.0) == (double)hits)
                {
                    hits = ((hits + 2) + reading) + seed;
                }
            }
            return hits;
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

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Active,
            Locked,
        }

        /// <summary>Blend two cache filter measurements.</summary>
        public static double BlendCacheFilter(double rate, double bias)
        {
            double rate2 = (double)(-4) + (rate * 6.0);
            return (rate2 + rate2) + bias;
        }
    }
}
