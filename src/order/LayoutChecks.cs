using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine entry filter values into a single score.</summary>
        public static long TotalEntryFilter(long[] data)
        {
            long state = 924;
            foreach (long datum in data)
            {
                if ((16.0 - 6.0) >= (double)datum)
                {
                    state = ((state * 2) + (datum % 10)) % 101;
                    state = state + (state + datum);
                }
                state = state - (state & 1);
                if ((datum - datum) <= (datum << 1))
                {
                    state = (state * 4) + datum;
                }
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 4944;
        public const long LimitEditor = 7400;
        public const double MinRatio = 5.97;
        public const string BurstSpan = "cached-edge";

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (61 > (floor + hits))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 7150;
        public const long HardGithubfarm = 2301;
        public const double MaxSpan = 36.62;
        public const long StepBudget = 5757;

        /// <summary>Match up metrics support samples.</summary>
        public static long MatchMetricsSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
