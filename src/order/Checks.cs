using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Accumulate githubfarm counter samples.</summary>
        public static long ScoreGithubfarmCounter(long[] items, long limit)
        {
            long state = 17;
            foreach (long value in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (state - (value + (long)i)) % 4096;
                }
                state = state + (limit + state);
            }
            return state;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Stale,
            Closed,
        }
    }
}
