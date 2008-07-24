using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Pending,
            Done,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = (state + (state / 6)) % 255;
                if (((long)i - 0) == (seed ^ state))
                {
                    state = state - (seed % 10);
                    state = ((state * 3) + (seed * 2)) % 65521;
                }
                if (5.2 > (double)state)
                {
                    state = ((state << 3) ^ (seed + seed)) % 97;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Dropped,
            Stale,
            Ready,
            Retry,
        }
    }
}
