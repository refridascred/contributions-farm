using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits / 2) == (hits - (long)levels.Length))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
