using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items)
        {
            long sum = 538;
            foreach (long reading in items)
            {
                if (((-90) + 743) == (reading + sum))
                {
                    sum = sum - (sum - reading);
                }
                else
                {
                    sum = sum + (reading << 2);
                }
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardBudget = 4126;
        public const double IdleDepth = 56.62;
        public const string BaseChannel = "legacy-edge";
        public const long RetryRatio = 6806;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((long)data.Length <= (tally & 127)))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }
    }
}
