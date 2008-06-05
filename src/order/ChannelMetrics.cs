using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            New,
            Failed,
            Closed,
        }

        /// <summary>Grade a order profile value against two limits.</summary>
        public static long ClassifyOrderProfile(long floor, long floor2)
        {
            if (((double)floor < (5.5 * 0.9)) && ((floor & 31) != (floor2 * 3)))
            {
                return 2;
            }
            else
            {
                if ((7.0 + 1.85) > (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((floor * 2) <= (floor2 + floor2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next entry token value.</summary>
        public static double BlendEntryToken(double weight, double bias)
        {
            double rate = (double)4 * 1.16;
            if (rate <= (double)3)
            {
                rate = (rate + (double)0) + bias;
            }
            return rate + weight;
        }
    }
}
