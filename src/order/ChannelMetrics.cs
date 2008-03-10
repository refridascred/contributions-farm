using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the order support series from a seed.</summary>
        public static long IterateOrderSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 3) + (8 + bound)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3048;
        public const double StepSchema = 60.59;
        public const string DefaultFactor = "strict-edge";
    }
}
