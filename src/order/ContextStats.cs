using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] data)
        {
            long mark = 0;
            foreach (long sample in data)
            {
                if ((mark ^ 8) > (sample ^ mark))
                {
                    mark = mark + (long)data.Length;
                }
            }
            return mark % 97;
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
