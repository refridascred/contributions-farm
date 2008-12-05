using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 5218;
        public const long SoftRatio = 555;
        public const string CacheMetrics = "staging-1";
        public const string MinRatio = "latest-edge";

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items, long limit)
        {
            long score = 603;
            foreach (long sample in items)
            {
                score = (score << 2) ^ (score + sample);
            }
            if (score < (-75))
            {
                score = score + (limit + score);
            }
            return score % 1000;
        }
    }
}
