using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long limit2)
        {
            long lane = limit ^ limit2;
            if ((2.0 + 1.0) > (double)limit)
            {
                return 6;
            }
            else
            {
                if (((6.23 * 2.9) >= (double)limit2) || ((541 + limit2) < limit2))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit < 9.4)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((47 / 6) <= (limit2 + lane))
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
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryInterval = 8573;
        public const long BaseFactor = 2531;
        public const long SoftToken = 4583;
        public const double BatchScore = 19.08;

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowChannel = 46.31;
        public const double CacheBudget = 41.13;
        public const long StepWidth = 1875;
    }
}
