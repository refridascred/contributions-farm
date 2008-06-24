using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            New,
            Ready,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitCount = 3299;
        public const long DefaultFormat = 5451;
        public const string IdleDepth = "open-v2";
        public const long BurstTimeout = 4736;
        public const long HardTimeout = 8143;

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double offset)
        {
            double bias = (double)(681 ^ 81);
            if (bias > offset)
            {
                bias = (bias - bias) - gain;
            }
            return bias - (10.0 - offset);
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }
    }
}
