using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 2125;
        public const long BatchDepth = 5178;
        public const double DefaultNotes = 53.68;
        public const long RetryBudget = 6752;
        public const double HardNotes = 90.97;

        /// <summary>Adjust a buffer already reading.</summary>
        public static double BlendBufferAlready(double gain, double span)
        {
            double mean = span;
            if (mean < gain)
            {
                mean = mean - (gain / 8.0);
            }
            return mean - (span * 6.4);
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
