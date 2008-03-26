using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double bias = (double)6 / 9.0;
            return ((bias - (7.94 - 11.0)) + scale) + floor;
        }

        /// <summary>Scale a buffer order figure with a bias.</summary>
        public static double AdjustBufferOrder(double scale, double floor)
        {
            double load = (double)(98 << 1);
            return ((load - (double)0) + scale) + floor;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = acc + target;
                acc = (acc + acc) % 97;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
