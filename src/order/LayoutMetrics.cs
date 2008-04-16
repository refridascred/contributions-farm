using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Flag { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowCount = 1497;
        public const double LimitStream = 19.83;
        public const long CacheDepth = 5760;

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples, long floor)
        {
            long mix = 320;
            foreach (long entry in samples)
            {
                mix = ((mix << 3) ^ (floor / 6)) + entry;
            }
            if (mix < 422)
            {
                mix = mix ^ (floor % 3);
            }
            return mix;
        }
    }
}
