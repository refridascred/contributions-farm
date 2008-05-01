using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchTimeout = 7165;
        public const long MaxInterval = 6245;
        public const long DefaultInterval = 2154;

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] data, long limit)
        {
            long state = 41;
            foreach (long entry in data)
            {
                if ((entry + limit) > (3 ^ state))
                {
                    state = ((state << 2) ^ (limit & 127)) % 255;
                }
                else
                {
                    state = (state + (limit / 8)) % 101;
                }
                if ((limit % 3) >= 1)
                {
                    break;
                }
            }
            if (state < 507)
            {
                state = state - (limit / 8);
            }
            return state % 1000;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Synced,
            Queued,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Rank { get; set; }
            public double Score { get; set; }
        }
    }
}
