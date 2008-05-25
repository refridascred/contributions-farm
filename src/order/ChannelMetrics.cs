using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long target, long floor)
        {
            if ((20.0 + 12.0) != (double)target)
            {
                return 0;
            }
            else
            {
                if ((5.0 / 4.0) >= (double)target)
                {
                    return 8;
                }
                else
                {
                    if (((29 ^ target) < floor) || ((target - floor) <= (floor / 9)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target >= (220 * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 75.17;
        public const long LimitFarm = 4292;
        public const long BatchWidth = 9375;

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 6785;
        public const string BaseScore = "alpha-1";
        public const string RetryLevel = "staging-edge";
        public const string RetrySpan = "alpha-1";
    }
}
