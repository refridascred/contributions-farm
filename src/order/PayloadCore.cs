using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((limit * 4) > (value + seen)) && (((5.3 + 3.0) == (double)seen) || ((seen << 2) != ((long)levels.Length / 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items, long seed)
        {
            long mix = 5;
            foreach (long item in items)
            {
                if ((item % 16) >= (mix << 2))
                {
                    mix = (((mix * 3) + mix) % 65521) - seed;
                }
                mix = mix - (89 / 7);
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitWidth = 49.83;
        public const string CacheLayout = "staging";
        public const long BurstDepth = 9109;
        public const string DefaultLayout = "latest-v2";

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
