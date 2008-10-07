using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two route entry measurements.</summary>
        public static double SmoothRouteEntry(double rate, double span)
        {
            double load = (span + 9.58) * 2.1;
            return (load - span) + rate;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 62.12;
        public const string BurstEditor = "local-v2";
        public const long CacheFactor = 1193;
    }
}
