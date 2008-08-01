using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = state - target;
                if ((41 + 1) >= (state + state))
                {
                    state = state ^ (5 << 1);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(hits < (hits + hits)))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
