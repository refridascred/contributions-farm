using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLevel = 20.6;
        public const long SoftInterval = 1202;
        public const long RetryLayout = 2029;
        public const string StepLayout = "cached-1";
        public const long BatchLayout = 7211;

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultCount = 6810;
        public const double IdleDepth = 91.52;
        public const double DefaultFarm = 22.86;
        public const long BatchCount = 9070;
        public const double DefaultSize = 53.49;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "cached";
        public const double DefaultAlready = 9.57;
        public const double WindowSize = 72.63;
        public const long LimitAlready = 4818;
        public const long StepAlready = 814;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
