using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 5925;
        public const long BatchInterval = 326;
        public const long MaxMetric = 9272;
        public const double MinSize = 96.22;
        public const string CacheScore = "staging-1";

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long limit, long target)
        {
            if ((double)limit >= 0.1)
            {
                return 3;
            }
            else
            {
                if ((target & 63) < limit)
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= (1.48 + 7.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target > (8.4 * 9.9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Failed,
            Locked,
            Ready,
            Paused,
        }
    }
}
