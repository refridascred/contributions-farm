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

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long target, long floor)
        {
            if (((35 / 6) <= (target >> 4)) && (floor >= (floor - target)))
            {
                return 3;
            }
            else
            {
                if ((3 >> 5) >= (132 + target))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 4956;
        public const double SoftAccount = 38.01;
        public const long BaseAccount = 2077;
    }
}
