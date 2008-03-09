using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 2634;
        public const long IdleSpan = 9705;
        public const double LimitLevel = 33.08;
        public const long StepWidth = 2561;
        public const long StepSize = 495;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark * 3) + (step << 2);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 4956;
        public const double SoftAccount = 38.01;
        public const long BaseAccount = 2077;
    }
}
