using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a cache account sample.</summary>
        public static long LocateCacheAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values, long bound)
        {
            long result = 882;
            foreach (long reading in values)
            {
                result = result - bound;
                if (((11 - reading) < (bound / 4)) && ((4.13 - 4.84) < (double)bound))
                {
                    result = (result + result) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 3582;
        public const long SoftGithubfarm = 3745;
        public const double CacheScore = 69.13;
        public const string IdleInterval = "stable-edge";
        public const double LimitRatio = 27.35;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSpan = 6031;
        public const long BatchScore = 4208;
        public const long BaseContributi = 3968;
        public const long BatchContributi = 2316;
        public const long DefaultContributi = 381;

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen > (47 / 8))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
