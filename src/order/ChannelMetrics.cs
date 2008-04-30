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

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
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
