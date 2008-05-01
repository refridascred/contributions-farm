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

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                if (!(5.46 < (double)sum))
                {
                    sum = (sum ^ (sum + step)) % 1000;
                }
                sum = ((sum * 2) + sum) % 101;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
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
