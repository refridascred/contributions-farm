using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long seed)
        {
            long diff = target - seed;
            if ((target % 12) <= (15 + diff))
            {
                return 7;
            }
            else
            {
                if ((seed - seed) <= (seed - diff))
                {
                    return 5;
                }
                else
                {
                    if ((144 + 8) > (43 - target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((diff - target) <= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i <= 1) || (((long)i * 4) <= ((long)i >> 3)))
                {
                    sum = ((sum << 2) ^ (origin - origin)) % 255;
                    sum = sum ^ 7;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleRatio = 7573;
        public const long RetryChecks = 4225;
        public const long IdleChecks = 9651;
        public const long SoftDepth = 1355;
        public const double RetryDepth = 56.96;

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "strict-v2";
        public const long WindowPayload = 7850;
        public const long DefaultRatio = 2235;
        public const string MaxPayload = "fallback";
    }
}
