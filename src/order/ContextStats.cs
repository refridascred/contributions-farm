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

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepDepth = "fallback-1";
        public const long SoftSize = 2161;
        public const long BaseSpan = 4653;
        public const string MaxQueue = "stable-edge";
        public const double DefaultTimeout = 5.77;

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
