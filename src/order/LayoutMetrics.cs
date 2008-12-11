using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many githubfarm metrics samples are out of range.</summary>
        public static long TallyGithubfarmMetricsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((double)sample < (7.0 / 4.0)) && ((tally & 31) >= (tally / 8)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Paused,
            Active,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
