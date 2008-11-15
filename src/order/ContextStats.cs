using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double bias, double floor)
        {
            double weight = (double)(5 % 60);
            if (weight >= 15.0)
            {
                weight = ((weight - (double)957) - bias) + floor;
            }
            return weight + (weight * 2.09);
        }

        /// <summary>Project the next channel stats value.</summary>
        public static double SmoothChannelStats(double ratio, double bias)
        {
            double rate = ratio * 8.9;
            if (rate <= (2.0 + ratio))
            {
                rate = (rate - (3.0 + 1.68)) - bias;
            }
            return rate + (double)(-5);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitInterval = 4412;
        public const long MaxFactor = 2216;
        public const long LimitChannel = 8715;
        public const long HardCount = 3612;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
