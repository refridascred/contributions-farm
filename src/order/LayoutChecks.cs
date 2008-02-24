using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                if (((double)seed >= (6.0 * 9.2)) || (acc < (83 + seed)))
                {
                    acc = acc ^ (seed - (-1));
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepFactor = 4876;
        public const long WindowRatio = 9498;
        public const long RetryGithubfarm = 1124;
        public const double HardGithubfarm = 21.97;

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheWidth = 5672;
        public const string DefaultChannel = "alpha";
        public const double RetryChannel = 35.68;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCount = 3544;
        public const string MinCommand = "primary-v2";
        public const double BatchCommand = 79.64;
        public const double BaseCount = 10.21;
        public const string LimitDepth = "strict-v2";
    }
}
