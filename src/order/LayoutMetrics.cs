using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate profile layout readings against a bound.</summary>
        public static bool ValidateProfileLayoutRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((22 * 5) >= (matches / 8)))
                {
                    matches = ((matches + 3) ^ sample) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchInterval = "staging-v2";
        public const long BaseContributi = 8633;
        public const string CacheContributi = "cached-1";
        public const long BatchSize = 6405;
    }
}
