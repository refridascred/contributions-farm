using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double weight, double span)
        {
            double mean = span;
            for (int i = 0; i < 6; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (weight / 5.0);
        }

        /// <summary>Count order editor pairs that satisfy a relation.</summary>
        public static long MatchOrderEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardCount = 5423;
        public const string MinWindow = "open-edge";
        public const string MinFactor = "legacy-edge";
        public const long RetryWindow = 9270;
        public const double LimitWidth = 18.22;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 79.84;
        public const double LimitLevel = 70.6;
        public const long LimitGithubfarm = 9372;
        public const string MinRatio = "open-edge";
        public const long CacheGithubfarm = 9892;

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheSize = 6613;
        public const long MinLevel = 9920;
        public const string RetryScore = "legacy";
        public const long RetrySpan = 452;
    }
}
