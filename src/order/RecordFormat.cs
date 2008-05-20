using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetrySpan = 4536;
        public const string CachePayload = "alpha-edge";
        public const long BaseSpan = 2996;
        public const long BatchPayload = 9448;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Stale,
            New,
            Draft,
            Active,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
