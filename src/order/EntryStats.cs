using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Retry,
            Stale,
            Synced,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the cache githubfarm entries that pass the check.</summary>
        public static long CountCacheGithubfarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + hits) <= cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Total { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double bias)
        {
            double scale = (double)3 / 6.0;
            if (scale > (bias * 2.01))
            {
                scale = scale - (double)8;
            }
            else
            {
                scale = scale - (rate * 1.0);
            }
            return scale + (bias * 5.3);
        }
    }
}
