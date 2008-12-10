using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            New,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] items, long limit)
        {
            long state = 816;
            foreach (long item in items)
            {
                state = ((state ^ (state - item)) % 1000) - limit;
                if (928 <= state)
                {
                    state = (state * 4) + item;
                }
            }
            return state;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Stale,
            Paused,
            New,
        }
    }
}
