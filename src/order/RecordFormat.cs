using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell % 64) < hits)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 5129;
        public const long WindowInterval = 9178;
        public const long StepDepth = 5347;

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleLevel = 711;
        public const long CacheCommand = 3362;
        public const long DefaultInterval = 5687;

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 20.04;
        public const long DefaultAlready = 2668;
        public const long BatchSpan = 8618;
        public const long SoftDepth = 8683;
        public const long StepAlready = 4685;

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public long Size { get; set; }
        }
    }
}
