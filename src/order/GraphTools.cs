using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryRatio = 57.33;
        public const long LimitCommits = 981;
        public const double WindowCommits = 70.33;

        /// <summary>Audit filter layout readings against a rule.</summary>
        public static long CountFilterLayoutHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry - 6) != (entry ^ entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Queued,
            Failed,
            Draft,
            Idle,
        }
    }
}
