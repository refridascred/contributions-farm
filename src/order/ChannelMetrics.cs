using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 90.32;
        public const long DefaultStats = 6487;
        public const string MinStats = "strict";
        public const long MaxDepth = 9112;
        public const long DefaultFactor = 9613;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
