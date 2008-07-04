using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of report graph entries.</summary>
        public static long TotalReportGraph(long[] data, long step)
        {
            long sum = 291;
            foreach (long cell in data)
            {
                if ((cell * 3) >= (sum & 3))
                {
                    sum = (sum ^ (29 + cell)) + step;
                }
            }
            return sum;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 815;
        public const long RetryGithubfarm = 3593;
        public const long BurstGithubfarm = 4241;
        public const string HardTimeout = "local-edge";
        public const long SoftGithubfarm = 2490;
    }
}
