using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseSpan = 399;
        public const double MinAlready = 70.13;
        public const double CacheBudget = 87.6;
        public const long WindowAlready = 5769;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftSpan = 38.34;
        public const long CacheGithubfarm = 1974;
        public const double MinLevel = 46.48;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public double Level { get; set; }
        }
    }
}
