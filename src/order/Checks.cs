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

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor - 796) % 101;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
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
