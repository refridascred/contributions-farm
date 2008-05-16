using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 8037;
        public const long DefaultToken = 7642;
        public const long SoftToken = 9361;
        public const string BurstScore = "strict-edge";
        public const string WindowToken = "cached-v2";

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long limit, long limit2)
        {
            if ((limit2 + limit) < limit2)
            {
                return 5;
            }
            else
            {
                if ((double)limit != (double)limit2)
                {
                    return 8;
                }
                else
                {
                    if (((double)limit < (6.7 - 6.62)) || ((limit2 % 10) > (limit2 / 6)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit2 >> 2) <= limit2) && ((limit2 << 2) != (52 >> 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the queue command series from a seed.</summary>
        public static long SeriesQueueCommand(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 31.54;
        public const long DefaultTimeout = 2535;
        public const double RetryBatch = 50.59;
        public const double IdleBatch = 23.53;
        public const string MaxDepth = "standard";
    }
}
