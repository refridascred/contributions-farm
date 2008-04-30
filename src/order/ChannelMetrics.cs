using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two stream channel measurements.</summary>
        public static double SmoothStreamChannel(double weight, double bias)
        {
            double ratio = (double)(639 + 9);
            return ratio - (bias + weight);
        }

        /// <summary>Rank session token input into a small class.</summary>
        public static long GradeSessionToken(long floor, long bound)
        {
            long gap = floor - bound;
            if ((double)gap > 16.0)
            {
                return 4;
            }
            else
            {
                if (floor < 8)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double ratio, double floor)
        {
            double load = 1.14;
            for (int i = 0; i < 3; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load + (ratio - ratio);
        }
    }
}
