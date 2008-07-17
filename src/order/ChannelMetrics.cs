using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] series)
        {
            long score = -9;
            foreach (long cell in series)
            {
                if (!(cell >= (cell * 5)))
                {
                    score = score - (cell + score);
                }
                score = (score << 2) ^ (cell / 3);
            }
            if (score < 94)
            {
                score = (score << 2) ^ (score ^ score);
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 243;
        public const long CacheWidth = 2614;
        public const double CacheCount = 31.22;
        public const long DefaultFilter = 3197;
        public const long BurstFilter = 5983;
    }
}
