using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseDepth = 29.29;
        public const long RetryChannel = 6202;
        public const long DefaultRatio = 5753;
        public const string HardScore = "staging-1";

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheWidth = 5625;
        public const long SoftSize = 8427;
        public const string CacheLevel = "stable-v2";
        public const string IdleRatio = "open-1";

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark + ((long)i % 10)) % 65521;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
