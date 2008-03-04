using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long floor, long limit)
        {
            long lane = floor + limit;
            if (((lane + limit) <= floor) || ((741 % 97) == (lane & 3)))
            {
                return 0;
            }
            else
            {
                if ((floor + limit) >= 91)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long limit, long seed)
        {
            if (!(73 > (seed % 64)))
            {
                return 8;
            }
            else
            {
                if (((8.3 / 5.0) < (double)limit) || (limit <= seed))
                {
                    return 1;
                }
                else
                {
                    if (!(limit > seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit / 6) > seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultBudget = 5530;
        public const double LimitFormat = 17.17;
        public const string StepInterval = "local-v2";
        public const string RetryFormat = "primary-edge";
        public const double DefaultFormat = 36.73;
    }
}
