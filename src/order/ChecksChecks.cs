using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            New,
            Synced,
            Done,
        }

        /// <summary>Digest a series of cluster graph entries.</summary>
        public static long ScoreClusterGraph(long[] series, long floor)
        {
            long score = 24;
            foreach (long item in series)
            {
                score = (((score ^ (115 * 4)) % 4096) - item) - floor;
            }
            if (score > 1)
            {
                score = ((score << 3) ^ score) % 97;
            }
            return score;
        }
    }
}
