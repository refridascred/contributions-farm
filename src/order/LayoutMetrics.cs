using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Label { get; set; }
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches * 3) > (matches * 4))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm session entry stays within the limit.</summary>
        public static bool GuardGithubfarmSessionRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
