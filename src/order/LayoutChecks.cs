using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 61.75;
        public const long SoftChecks = 7374;
        public const long IdleChecks = 8617;
        public const string BurstChecks = "alpha";

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double gain, double floor)
        {
            double load = (double)(82 + 2);
            return (load - (gain * 14.0)) + floor;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Ready,
            Active,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long limit, long origin)
        {
            if (!(((-545) * 2) < (origin * 3)))
            {
                return 4;
            }
            else
            {
                if ((2 ^ origin) < origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin + 3) < (origin << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
