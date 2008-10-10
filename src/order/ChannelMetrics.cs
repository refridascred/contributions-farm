using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 95.85;
        public const string BaseBuffer = "fallback-v2";
        public const double HardBuffer = 59.22;
        public const string IdleBudget = "stable";

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if ((87 / 2) != (step + (long)i))
                {
                    acc = (acc - ((long)i ^ step)) % 1000;
                    acc = (acc - (step + acc)) % 101;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 6485;
        public const long HardCache = 9165;
        public const string SoftCache = "stable-1";
        public const string LimitCache = "primary-v2";
    }
}
