using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "cached-edge";
        public const long IdleDepth = 3055;
        public const long BaseStream = 922;
        public const long StepSpan = 3338;

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 1182;
        public const double HardSchema = 17.38;
        public const long IdleSpan = 732;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (39 >> 5)) % 4096;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
