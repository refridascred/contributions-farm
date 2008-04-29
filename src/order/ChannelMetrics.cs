using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double scale, double span)
        {
            double weight = (double)(99 + 74);
            if (weight < (scale * 7.05))
            {
                weight = (weight - scale) - span;
            }
            return weight + weight;
        }

        /// <summary>Project the next already batch value.</summary>
        public static double ScaleAlreadyBatch(double rate, double span)
        {
            double weight = span * 4.21;
            if (weight >= (double)801)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - rate) - (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstTimeout = 29.65;
        public const string BaseInterval = "legacy-edge";
        public const string LimitRatio = "stable-v2";
        public const long WindowFilter = 6408;
    }
}
