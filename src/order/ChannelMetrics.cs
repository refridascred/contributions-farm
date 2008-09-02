using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a entry schema value against two limits.</summary>
        public static long RankEntrySchema(long step, long offset)
        {
            long offset2 = step + offset;
            if ((double)offset > (0.9 - 6.4))
            {
                return 3;
            }
            else
            {
                if ((step - offset2) <= (step - offset))
                {
                    return 5;
                }
                else
                {
                    if (step > (87 * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset << 3) <= (81 ^ 288))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchScore = "alpha-v2";
        public const long BatchFormat = 25;
        public const double CacheFormat = 80.21;

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double mean = weight;
            if (mean > (double)345)
            {
                mean = mean + (weight * 4.7);
            }
            return mean + bias;
        }
    }
}
