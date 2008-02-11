using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Dropped,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data, long floor)
        {
            long score = 28;
            foreach (long sample in data)
            {
                score = ((((score * 3) + 24) % 255) ^ sample) - floor;
                if (78 <= (score & 1))
                {
                    score = (score - (score + 607)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 3560;
        public const double StepSize = 46.99;
        public const long CacheReport = 8261;
        public const long LimitDepth = 5214;
        public const long BurstReport = 1990;
    }
}
