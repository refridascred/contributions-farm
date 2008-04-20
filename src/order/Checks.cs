using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                long hits = (64 + origin) ^ result;
                if ((double)hits != (1.1 * 2.4))
                {
                    hits = (hits - (origin + hits)) % 4096;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryLevel = "standard-v2";
        public const long WindowCounter = 9702;
        public const long MaxInterval = 3531;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Retry,
            Closed,
            Idle,
        }
    }
}
