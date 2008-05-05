using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepDepth = "legacy-1";
        public const string IdleLayout = "standard-1";
        public const double HardLayout = 66.29;
        public const long CacheLayout = 9247;

        /// <summary>Check that every token cluster entry stays within the limit.</summary>
        public static bool GuardTokenClusterRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 8717;
        public const double StepOrder = 65.32;
        public const double BatchOrder = 41.83;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Dropped,
            Queued,
            Closed,
            Idle,
        }
    }
}
