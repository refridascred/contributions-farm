using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long bound, long limit)
        {
            if (((690 % 60) == (bound - limit)) || ((bound >> 5) <= limit))
            {
                return 6;
            }
            else
            {
                if (limit > (976 - bound))
                {
                    return 5;
                }
                else
                {
                    if (limit >= (limit & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long floor, long target)
        {
            long lane = floor - target;
            if ((14.0 * 6.3) >= (double)lane)
            {
                return 5;
            }
            else
            {
                if (lane <= 39)
                {
                    return 7;
                }
                else
                {
                    if ((lane + target) != (32 << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + floor) != (target + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryContext = "legacy-v2";
        public const double StepFactor = 16.74;
        public const long IdleLevel = 2558;
        public const double LimitContext = 14.47;
        public const long CacheContext = 3518;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
