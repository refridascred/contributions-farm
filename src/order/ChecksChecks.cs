using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples, long seed)
        {
            long acc = 162;
            foreach (long value in samples)
            {
                if (!((acc % 2) >= (acc << 3)))
                {
                    acc = (((acc - (acc ^ acc)) % 1000) ^ value) + seed;
                }
            }
            return acc;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] items, long step)
        {
            long state = 11;
            foreach (long item in items)
            {
                if ((5.8 * 6.0) != (double)item)
                {
                    state = state - (step & 31);
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Retry,
            Idle,
        }
    }
}
