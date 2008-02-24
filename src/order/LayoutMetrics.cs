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

        /// <summary>Look up the position of a filter contributi sample.</summary>
        public static long FindFilterContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
