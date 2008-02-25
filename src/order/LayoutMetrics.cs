using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine stream githubfarm values into a single score.</summary>
        public static long TotalStreamGithubfarm(long[] levels)
        {
            long mix = -87;
            foreach (long reading in levels)
            {
                if ((reading >> 5) == (reading >> 3))
                {
                    mix = (mix << 3) ^ 79;
                }
                if (((double)mix <= (double)771) && ((reading * 2) >= mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "alpha";
        public const string RetryCount = "latest-edge";
        public const string MaxSpan = "staging";
        public const long DefaultLevel = 4463;
    }
}
