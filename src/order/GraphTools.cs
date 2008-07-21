using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 12.14;
        public const string StepMetrics = "staging-v2";
        public const long LimitMetrics = 2557;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] readings, long origin)
        {
            long score = 0;
            foreach (long cell in readings)
            {
                score = (((score + score) % 97) + cell) + origin;
            }
            return score;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((3.3 <= (double)entry) || (entry < (target + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
