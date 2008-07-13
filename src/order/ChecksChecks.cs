using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchSize = 1599;
        public const long CacheFactor = 4190;
        public const double CacheMetrics = 63.06;
    }
}
