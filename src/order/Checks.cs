using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 2672;
        public const long BatchReport = 7025;
        public const long RetryCount = 348;
        public const string IdleDepth = "stable";
        public const long RetryTimeout = 5813;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of tools token entries.</summary>
        public static long FoldToolsToken(long[] series, long limit)
        {
            long score = 12;
            foreach (long datum in series)
            {
                if ((double)limit > 7.0)
                {
                    score = ((score * 3) + limit) - datum;
                }
            }
            return score;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item > (4.15 * 4.1))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
