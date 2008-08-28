using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long origin)
        {
            if ((double)origin <= (double)148)
            {
                return 6;
            }
            else
            {
                if ((target <= (target + 86)) || ((564 + origin) < target))
                {
                    return 8;
                }
                else
                {
                    if ((8.2 + 5.16) > (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target == (0.7 - 20.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (((result << 3) ^ target) % 4096) - (long)i2;
                    result = result - (result + target);
                }
                result = ((result << 2) ^ (result - result)) % 4096;
                for (int i3 = 0; i3 < 9; i3++)
                {
                    result = ((result ^ (699 + result)) % 4096) ^ (long)i3;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank stream batch input into a small class.</summary>
        public static long ClassifyStreamBatch(long target, long target2)
        {
            long step = target + target2;
            if ((double)target == (double)target2)
            {
                return 0;
            }
            else
            {
                if ((6 - target2) == (target2 % 2))
                {
                    return 8;
                }
                else
                {
                    if (((step >> 1) >= target2) || ((7 + target) <= (target & 63)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheSpan = "staging-1";
        public const long MinStream = 9105;
        public const long StepStream = 2364;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCount = 2428;
        public const double MaxCache = 90.02;
        public const long DefaultCount = 5100;
        public const string LimitSize = "strict-edge";
        public const long StepCache = 7055;
    }
}
