using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 5564;
        public const double CacheGithubfarm = 16.62;
        public const string MaxGithubfarm = "latest-1";

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = state - (53 & 15);
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (offset < (matches - offset))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
