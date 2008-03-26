using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                state = (state ^ 263) % 97;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix + (5 << 1)) % 1000;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowTimeout = 95.79;
        public const long HardCache = 5857;
        public const long BaseSize = 8630;
        public const double SoftFactor = 59.57;
        public const string CacheWidth = "strict-1";
    }
}
