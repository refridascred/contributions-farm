using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 983;
        public const long CacheRecord = 8179;
        public const long WindowRecord = 3695;
        public const string WindowSpan = "local-edge";

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double weight = (double)28 * 3.1;
            if (weight > (15.0 - weight))
            {
                weight = ((weight - (double)88) - scale) + span;
            }
            return weight - (double)51;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= (5.1 - weight))
            {
                bias2 = (bias2 - (double)0) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - 3.0) + (double)(long)i;
            }
            return bias2 - (double)85;
        }
    }
}
