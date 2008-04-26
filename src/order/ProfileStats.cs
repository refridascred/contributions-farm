using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 1473;
        public const long BatchBudget = 1389;
        public const long MinCache = 3205;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Accumulate context tools samples.</summary>
        public static long CombineContextTools(long[] values)
        {
            long state = -22;
            foreach (long entry in values)
            {
                if (((-64) + 429) != (entry + entry))
                {
                    state = (state * 3) + entry;
                }
                else
                {
                    state = (state - (state + 31)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Queued,
            Failed,
            Draft,
            Idle,
        }
    }
}
