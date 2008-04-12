using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine channel context values into a single score.</summary>
        public static long TallyChannelContext(long[] items)
        {
            long anchor = 1;
            foreach (long entry in items)
            {
                anchor = (anchor ^ anchor) ^ entry;
                if ((2.84 + 2.46) > (double)anchor)
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxBudget = "cached-1";
        public const long HardFactor = 2240;
        public const long BurstCounter = 7665;
        public const double MinDepth = 10.05;
        public const string DefaultCount = "standard-edge";

        /// <summary>Count githubfarm entry pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public bool Label { get; set; }
        }
    }
}
