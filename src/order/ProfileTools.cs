using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long seed, long floor)
        {
            long bound = seed + floor;
            if (!((10.0 - 20.0) == (double)seed))
            {
                return 4;
            }
            else
            {
                if ((double)bound < (15.0 + 4.8))
                {
                    return 5;
                }
                else
                {
                    if ((double)419 != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((12.0 - 7.3) < (double)seed) || ((double)bound <= (8.0 * 6.0)))
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

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long target, long origin)
        {
            long edge = target - origin;
            if ((6.0 + 5.8) == (double)edge)
            {
                return 8;
            }
            else
            {
                if ((target % 8) > edge)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double bias = span / 5.0;
            if (bias > (double)8)
            {
                bias = bias + rate;
            }
            else
            {
                bias = bias - (double)99;
            }
            return bias - rate;
        }

        /// <summary>Audit route commits readings against a rule.</summary>
        public static long CountRouteCommitsHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen > (sample ^ 49)) && ((step + (long)data.Length) >= step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
