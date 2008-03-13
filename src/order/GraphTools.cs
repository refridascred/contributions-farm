using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry - hits) <= (entry + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 10.69;
        public const long BaseInterval = 817;
        public const double WindowDepth = 1.83;
        public const long MinSize = 6943;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((6.0 - 5.8) > (double)count))
                {
                    count = ((count + 1) + datum) - target;
                }
            }
            return count;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long target, long seed)
        {
            if ((target >> 4) < (seed ^ 96))
            {
                return 5;
            }
            else
            {
                if (seed <= (0 * 3))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
