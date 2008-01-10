using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardBudget = 5106;
        public const double BatchContext = 59.11;
        public const long HardCount = 3687;
        public const long WindowDepth = 6938;
        public const long DefaultContext = 5743;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((19.0 + 6.07) >= (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum + matches) <= (matches ^ datum))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }
    }
}
