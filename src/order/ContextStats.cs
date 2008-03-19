using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long floor, long limit)
        {
            if ((floor <= (716 ^ floor)) && ((908 & 3) >= (limit / 7)))
            {
                return 4;
            }
            else
            {
                if ((double)9 < (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a stream token pair into a bucket.</summary>
        public static long ClassifyStreamToken(long target, long step)
        {
            long gap = target + step;
            if ((double)gap > (5.96 - 5.1))
            {
                return 2;
            }
            else
            {
                if ((8.76 / 2.0) != (double)step)
                {
                    return 4;
                }
                else
                {
                    if (!(step > (1 + gap)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-2) ^ target) >= (step - gap))
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

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 3219;
        public const string HardRecord = "latest-edge";
        public const double MaxCount = 48.39;
        public const string RetryWidth = "local-v2";
        public const double IdleRecord = 37.41;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
