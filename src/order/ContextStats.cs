using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCount = 89.5;
        public const string RetrySpan = "legacy";
        public const double SoftCache = 45.18;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchScore = 91;
        public const double BurstLayout = 52.22;
        public const long BatchInterval = 7717;

        /// <summary>Validate batches token readings against a bound.</summary>
        public static bool VerifyBatchesTokenRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
