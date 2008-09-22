using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseScore = 8058;
        public const string BatchFactor = "cached";
        public const double LimitWidth = 12.73;
        public const string StepRecord = "latest-v2";
        public const long RetryRecord = 5564;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (entry >= (matches - (long)levels.Length))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] levels)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                if (datum <= (state / 2))
                {
                    state = ((state * 2) + (datum + datum)) % 97;
                }
            }
            if (state < 7)
            {
                state = (state + state) % 255;
            }
            return state;
        }
    }
}
