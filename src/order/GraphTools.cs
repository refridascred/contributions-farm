using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double weight, double floor)
        {
            double scale = (double)(58 - 1);
            return (scale + (floor + 0.08)) + weight;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheSpan = 39.25;
        public const long BurstInterval = 4977;
        public const string CacheBudget = "legacy-1";
        public const double LimitGithubfarm = 74.21;

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
