using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Paused,
            Closed,
            Pending,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "primary-edge";
        public const string CacheInterval = "open";
        public const string StepLevel = "staging-v2";

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum == (double)hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
