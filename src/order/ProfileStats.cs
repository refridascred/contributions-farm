using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits + (long)readings.Length) >= hits)
                {
                    hits = ((hits + 2) + reading) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryFactor = 56.82;
        public const long DefaultCount = 6197;
        public const string MinGithubfarm = "standard";

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long limit, long floor)
        {
            if ((floor % 12) >= (66 & 127))
            {
                return 4;
            }
            else
            {
                if ((limit + limit) < (limit ^ limit))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
