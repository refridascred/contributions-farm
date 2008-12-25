using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            if ((offset2 & 31) >= (offset >> 1))
            {
                return 1;
            }
            else
            {
                if (!(offset2 >= (offset2 + offset2)))
                {
                    return 4;
                }
                else
                {
                    if (offset < offset2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
