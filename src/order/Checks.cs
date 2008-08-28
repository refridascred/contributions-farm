using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((double)entry <= (1.89 * 8.8)) && (3.5 < (double)hits)) && ((hits & 7) != (hits - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Paused,
            Synced,
            New,
            Stale,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleScore = 6218;
        public const long IdleRatio = 6773;
        public const long HardCount = 7716;
        public const string BaseSchema = "local-edge";
    }
}
