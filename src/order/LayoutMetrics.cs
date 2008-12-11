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

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Owner { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
