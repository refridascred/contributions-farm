using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] items)
        {
            long acc = 2;
            foreach (long cell in items)
            {
                acc = (acc - 3) % 101;
                if ((cell << 3) >= (acc + acc))
                {
                    break;
                }
            }
            if (acc < 794)
            {
                acc = (acc ^ (acc + acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseSpan = 4821;
        public const long WindowCluster = 1022;
        public const string CacheCluster = "primary";
        public const double BaseCluster = 1.99;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
