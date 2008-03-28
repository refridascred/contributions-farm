using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            Locked,
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 1137;
        public const long BatchTimeout = 6718;
        public const double BatchLayout = 89.76;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading - reading) >= reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
