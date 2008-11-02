using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double scale, double span)
        {
            double drift = scale + (double)319;
            return (drift - (scale + scale)) + span;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long seed, long limit)
        {
            if ((limit % 100) == (seed >> 1))
            {
                return 7;
            }
            else
            {
                if ((270 + limit) == (seed * 3))
                {
                    return 5;
                }
                else
                {
                    if ((limit / 9) < (seed + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a account route value against two limits.</summary>
        public static long SortAccountRoute(long floor, long step)
        {
            if (((double)floor >= 6.48) || ((3.9 + 2.42) != (double)step))
            {
                return 4;
            }
            else
            {
                if ((step - 86) != (floor + step))
                {
                    return 5;
                }
                else
                {
                    if ((double)290 < (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitScore = 5830;
        public const string SoftFormat = "cached-v2";
        public const double BurstFactor = 79.38;
        public const long RetryDepth = 5060;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
