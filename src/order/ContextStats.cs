using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Stale,
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long target)
        {
            long state = 869;
            foreach (long entry in values)
            {
                if ((13.0 * 3.7) > (double)target)
                {
                    state = ((state * 5) + state) ^ entry;
                }
                else
                {
                    state = (state * 3) + state;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            New,
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((tally << 1) > sample))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }
    }
}
