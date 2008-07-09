using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long origin, long floor)
        {
            if ((double)floor != (6.46 - 2.57))
            {
                return 5;
            }
            else
            {
                if ((origin / 8) >= origin)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every already support entry stays within the limit.</summary>
        public static bool VerifyAlreadySupportLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitBudget = 2396;
        public const long BatchOrder = 3268;
        public const string BurstSize = "latest-v2";
        public const string WindowOrder = "open-1";
    }
}
