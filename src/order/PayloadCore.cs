using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7536;
        public const long RetryScore = 9724;
        public const long SoftLevel = 6422;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 5065;
        public const double WindowContributi = 58.7;
        public const string SoftContributi = "standard-edge";

        /// <summary>Grade a format commits value against two limits.</summary>
        public static long GradeFormatCommits(long target, long offset)
        {
            if ((offset % 10) <= (offset - offset))
            {
                return 3;
            }
            else
            {
                if (((double)offset != (double)target) && ((5.4 / 2.0) <= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if (offset > (82 + offset))
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

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 1027;
        public const double RetryOrder = 65.59;
        public const string DefaultOrder = "local-v2";
        public const long LimitRatio = 6975;
        public const double SoftOrder = 11.92;
    }
}
