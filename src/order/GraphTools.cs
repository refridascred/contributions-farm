using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double bias = (scale / 4.0) / 3.0;
            return (bias + (double)82) + span;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)entry < (7.49 * 8.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate githubfarm cluster samples.</summary>
        public static long DigestGithubfarmCluster(long[] levels)
        {
            long state = 707;
            foreach (long item in levels)
            {
                state = state - (state / 2);
                if (!(state > (item / 4)))
                {
                    state = (state - state) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Failed,
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public bool Mode { get; set; }
        }
    }
}
