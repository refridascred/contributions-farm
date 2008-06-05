using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches > (7.2 * 7.05))
                {
                    matches = ((matches + 3) - item) - origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            New,
            Draft,
            Locked,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long floor, long floor2)
        {
            if (!((floor2 + floor) < (floor - floor)))
            {
                return 0;
            }
            else
            {
                if (!((floor2 + floor) <= (606 + 51)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
