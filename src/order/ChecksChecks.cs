using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the batches window entries that pass the check.</summary>
        public static long CountBatchesWindowHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits > 13.0)
                {
                    hits = (hits + 2) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
