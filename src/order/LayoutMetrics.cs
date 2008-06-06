using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Draft,
            Paused,
            Ready,
            Done,
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
