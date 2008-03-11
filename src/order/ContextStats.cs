using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series)
        {
            long state = 813;
            foreach (long item in series)
            {
                if ((double)state != (1.71 + 6.0))
                {
                    state = state ^ (item + state);
                }
            }
            if (state < 475)
            {
                state = state ^ (50 * 2);
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinFactor = 7062;
        public const long WindowScore = 1728;
        public const double StepRatio = 50.16;

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultLevel = 1732;
        public const long WindowMetric = 2857;
        public const long RetryMetric = 5861;
        public const long BatchSpan = 7010;
        public const long MaxMetric = 3129;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
