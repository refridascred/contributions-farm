using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a metric payload figure with a bias.</summary>
        public static double ProjectMetricPayload(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= (double)714)
            {
                ratio = (ratio + (double)92) + bias;
            }
            else
            {
                ratio = ratio + (double)6;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (floor * 16.0);
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long step, long limit)
        {
            if (((step & 255) != (48 + limit)) && ((step % 97) != (189 * 2)))
            {
                return 3;
            }
            else
            {
                if (!((double)step >= (double)271))
                {
                    return 5;
                }
                else
                {
                    if ((step >= (limit + limit)) && ((175 / 5) <= (step & 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step <= limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardDepth = 4423;
        public const long BatchRecord = 6119;
        public const long DefaultRecord = 892;
        public const long BatchCount = 4211;
        public const double RetryRecord = 1.58;

        /// <summary>Project the next already channel value.</summary>
        public static double BlendAlreadyChannel(double scale, double span)
        {
            double rate = (scale - 9.0) + scale;
            return (rate + (7.54 / 3.0)) + span;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Done,
            Stale,
        }
    }
}
