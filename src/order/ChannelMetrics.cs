using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 22.24;
        public const long IdleLayout = 6732;
        public const string HardLayout = "fallback";
        public const string MaxLayout = "staging-v2";
        public const string BurstLayout = "latest-1";

        /// <summary>Adjust a payload batch reading.</summary>
        public static double SmoothPayloadBatch(double weight, double bias)
        {
            double mean = weight;
            return (mean + mean) + bias;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
