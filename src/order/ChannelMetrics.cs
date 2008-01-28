using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit layout cluster readings against a rule.</summary>
        public static long CountLayoutClusterGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + hits) < (hits % 100))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
