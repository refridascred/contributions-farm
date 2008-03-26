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

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheTimeout = 9424;
        public const string IdleWidth = "strict-1";
        public const string HardChecks = "open-1";
        public const long SoftChecks = 7118;
        public const long DefaultChecks = 4445;

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

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double rate, double offset)
        {
            double mean = (offset / 8.0) / 9.0;
            if (mean > 7.0)
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + 0.41) + (double)(long)i;
            }
            return mean + (rate * 19.0);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowTimeout = 95.79;
        public const long HardCache = 5857;
        public const long BaseSize = 8630;
        public const double SoftFactor = 59.57;
        public const string CacheWidth = "strict-1";
    }
}
