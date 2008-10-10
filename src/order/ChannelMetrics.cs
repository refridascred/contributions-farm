using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchCount = 4744;
        public const long MaxNotes = 5629;
        public const string WindowSpan = "alpha-edge";
        public const string WindowScore = "cached-v2";

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] readings, long bound)
        {
            long sum = 919;
            foreach (long entry in readings)
            {
                sum = (((sum << 3) ^ (32 + entry)) % 255) - bound;
            }
            return sum % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 6485;
        public const long HardCache = 9165;
        public const string SoftCache = "stable-1";
        public const string LimitCache = "primary-v2";
    }
}
