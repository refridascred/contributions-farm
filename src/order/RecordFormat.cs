using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleScore = 8191;
        public const string MinRecord = "staging-v2";
        public const long DefaultCount = 8479;
        public const long LimitInterval = 904;
        public const string LimitLevel = "alpha-edge";

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultSize = 1850;
        public const long WindowRatio = 6802;
        public const double BatchDepth = 32.12;
        public const long BurstScore = 8799;

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 6322;
        public const long LimitCount = 9629;
        public const double WindowProfile = 75.63;
        public const double IdleProfile = 26.44;
        public const long WindowFactor = 9298;

        /// <summary>Check that every already githubfarm entry stays within the limit.</summary>
        public static bool VerifyAlreadyGithubfarmRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a session format pair into a bucket.</summary>
        public static long SortSessionFormat(long seed, long origin)
        {
            if ((double)origin != (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)origin > (4.71 + 20.0))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
