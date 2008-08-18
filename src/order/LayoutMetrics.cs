using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Retry,
            Paused,
            Active,
        }

        /// <summary>Count the account farm entries that pass the check.</summary>
        public static long CountAccountFarmHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((matches - limit) < (matches ^ reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }
    }
}
