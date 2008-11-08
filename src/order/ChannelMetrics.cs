using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 25.36;
        public const long MaxTools = 7915;
        public const double RetryWidth = 92.65;
        public const string SoftRatio = "strict-edge";

        /// <summary>Iterate the order window series from a seed.</summary>
        public static long DeriveOrderWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i << 3) > sum) && (sum >= ((long)i - sum)))
                {
                    sum = ((sum << 3) ^ (sum - (long)i)) % 1000;
                    sum = (sum + ((long)i & 7)) % 65521;
                }
                else
                {
                    sum = (sum + (floor ^ sum)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank metric filter input into a small class.</summary>
        public static long BucketMetricFilter(long step, long seed)
        {
            long offset = step - seed;
            if (!((13.0 * 18.0) < (double)offset))
            {
                return 6;
            }
            else
            {
                if (((-8) >= (step + seed)) && ((seed + seed) >= (offset + offset)))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset == (4.31 - 11.0)) && ((step % 8) == (step + seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
