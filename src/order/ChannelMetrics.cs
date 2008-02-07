using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryRatio = 7878;
        public const double MinScore = 56.54;
        public const long StepCommand = 3523;
        public const long RetryWidth = 9150;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Ratio { get; set; }
            public double Label { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
