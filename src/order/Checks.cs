using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "legacy-v2";
        public const long LimitSpan = 938;
        public const long MinGraph = 8979;
        public const string CacheSize = "latest-1";

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 398;
        public const long BurstOrder = 3152;
        public const double BatchOrder = 79.5;
        public const long CacheScore = 8412;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long seed, long origin)
        {
            if (0.9 >= (double)seed)
            {
                return 5;
            }
            else
            {
                if ((9.45 - 9.4) != (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public bool Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
