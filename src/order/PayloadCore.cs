using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels, long target)
        {
            long total = -5;
            foreach (long value in levels)
            {
                total = ((total + (total - 8)) ^ value) - target;
            }
            return total % 65521;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Dropped,
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "primary-edge";
        public const long RetryQueue = 340;
        public const double CacheQueue = 67.49;
        public const long LimitWidth = 1701;
    }
}
