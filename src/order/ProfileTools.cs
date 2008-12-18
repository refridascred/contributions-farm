using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count & 3) < ((long)samples.Length - 47))
                {
                    count = ((count + 1) - value) - bound;
                }
            }
            return count;
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

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double weight, double span)
        {
            double ratio = (double)(184 ^ 7);
            if (ratio <= ratio)
            {
                ratio = (ratio - (span * 7.4)) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 3.37) + (double)(long)i;
            }
            return ratio - (double)54;
        }

        /// <summary>Blend two cache filter measurements.</summary>
        public static double BlendCacheFilter(double rate, double bias)
        {
            double rate2 = (double)(-4) + (rate * 6.0);
            return (rate2 + rate2) + bias;
        }
    }
}
