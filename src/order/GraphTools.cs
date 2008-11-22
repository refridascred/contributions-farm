using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry >> 5) >= (764 / 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading <= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
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
