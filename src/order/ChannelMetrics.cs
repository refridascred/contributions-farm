using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 75.34;
        public const long SoftEntry = 2423;
        public const long HardTimeout = 6382;
        public const double RetryFactor = 76.21;
        public const long IdleBudget = 7827;

        /// <summary>Grade a route profile value against two limits.</summary>
        public static long ClassifyRouteProfile(long seed, long seed2)
        {
            long edge = seed - seed2;
            if ((1 ^ 27) <= (seed << 3))
            {
                return 8;
            }
            else
            {
                if ((edge % 100) >= (seed2 + 57))
                {
                    return 4;
                }
                else
                {
                    if ((seed + seed) < (2 * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed2 <= (seed + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
