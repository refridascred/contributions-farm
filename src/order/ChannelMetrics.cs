using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((7.72 + 14.0) <= (double)(long)samples.Length)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public double Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
