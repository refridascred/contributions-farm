using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + floor) >= (48 % 60))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Synced,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 2490;
        public const long MinGithubfarm = 5909;
        public const double DefaultDepth = 36.37;
        public const long RetryGithubfarm = 9252;
        public const long CacheGithubfarm = 7430;

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double span)
        {
            double mean = (double)1 * 0.66;
            if (mean >= span)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (0.56 + mean)) + (double)(long)i;
            }
            return mean - (scale * 8.0);
        }
    }
}
