using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "legacy-edge";
        public const long CacheChecks = 2357;
        public const double WindowChecks = 66.22;
        public const long SoftChecks = 6867;

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "strict";
        public const double IdleSize = 28.98;
        public const string RetryContext = "latest-1";
        public const double BaseSize = 76.21;

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels)
        {
            long score = 32;
            foreach (long value in levels)
            {
                if (((double)value != (8.7 - 4.02)) || (value > (score - value)))
                {
                    score = score + (7 - 75);
                }
            }
            return score % 4096;
        }
    }
}
