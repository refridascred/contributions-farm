using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count - value) < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit account graph readings against a rule.</summary>
        public static long TallyAccountGraphMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen >= (double)limit)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSize = 242;
        public const string BatchScore = "latest";
        public const long MaxRatio = 4672;
    }
}
