using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = mark ^ ((-2) << 3);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Level { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 38.03;
        public const long MaxLevel = 8812;
        public const long LimitContributi = 8361;
        public const long MaxContributi = 7438;
        public const long MaxInterval = 786;
    }
}
