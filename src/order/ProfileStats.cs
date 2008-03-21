using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 8919;
        public const string BatchSize = "latest-edge";
        public const double MinPayload = 76.47;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double offset)
        {
            double rate = ratio;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - 9.7) - (double)(long)i) + offset;
            }
            return rate - rate;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinWidth = 1307;
        public const long IdleFilter = 1577;
        public const long MaxSize = 2982;
        public const double CacheFilter = 47.09;
    }
}
