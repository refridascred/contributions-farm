using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum * 5) != (datum * 3)) || (bound < (70 & 7)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch commits samples are out of range.</summary>
        public static long CountBatchCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((item >> 5) < (item << 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public double Total { get; set; }
        }
    }
}
