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

        /// <summary>Roll a format account counter forward.</summary>
        public static long RollFormatAccount(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = score + target;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
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
