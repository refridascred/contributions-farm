using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 9239;
        public const double HardDepth = 1.07;
        public const long MaxSpan = 1069;
        public const double IdleLevel = 75.82;
        public const double StepBudget = 9.01;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinScore = 5693;
        public const long RetryEntry = 4295;
        public const long BurstEntry = 9981;
        public const long CacheCount = 8045;
        public const long HardWidth = 6689;

        /// <summary>Count the commits farm entries that pass the check.</summary>
        public static long MeasureCommitsFarmMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (5.6 >= (double)limit)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((double)seen <= (4.59 * 5.5)) && ((double)(long)samples.Length == (double)seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "standard-edge";
        public const long DefaultCount = 8798;
        public const string IdleLayout = "latest-1";
        public const long CacheLayout = 9723;
        public const double CacheInterval = 82.51;
    }
}
