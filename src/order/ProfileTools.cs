using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Pending,
            Draft,
            New,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every cache profile entry stays within the limit.</summary>
        public static bool VerifyCacheProfileLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
