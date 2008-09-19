using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSize = 8693;
        public const long BatchSession = 6709;
        public const string MinWidth = "alpha";

        /// <summary>Check that every checks window entry stays within the limit.</summary>
        public static bool ValidateChecksWindowRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Size { get; set; }
        }
    }
}
