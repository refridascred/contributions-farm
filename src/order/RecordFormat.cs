using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowSpan = "cached-edge";
        public const double WindowAlready = 36.96;
        public const long BaseAlready = 5824;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
