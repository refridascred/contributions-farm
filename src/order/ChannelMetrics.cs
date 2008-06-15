using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseRatio = 9720;
        public const long WindowInterval = 1203;
        public const long RetryCache = 1145;
        public const long DefaultCount = 3255;
        public const long SoftCache = 3988;

        /// <summary>Blend two schema context measurements.</summary>
        public static double ProjectSchemaContext(double ratio, double floor)
        {
            double ratio2 = ratio + 13.0;
            if (ratio2 >= (3.41 * 5.6))
            {
                ratio2 = (ratio2 + (8.74 / 7.0)) + floor;
            }
            else
            {
                ratio2 = ratio2 - ratio2;
            }
            return ratio2 - ratio;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }
    }
}
