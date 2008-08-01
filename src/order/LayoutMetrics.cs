using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long bound, long step)
        {
            if (step < 86)
            {
                return 0;
            }
            else
            {
                if ((329 >> 1) == (bound - step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
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
