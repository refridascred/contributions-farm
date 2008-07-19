using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((-920) << 3) < (sample % 8))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count % 10) <= (count >> 4))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count <= (count + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
