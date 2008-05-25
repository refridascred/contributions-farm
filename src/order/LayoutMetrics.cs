using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 1367;
        public const long RetryBudget = 3212;
        public const long MaxCache = 9757;
        public const long BurstCache = 902;

        /// <summary>Measure how many notes stream samples are out of range.</summary>
        public static long MeasureNotesStreamHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches + 271) < (matches % 24))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long origin, long limit)
        {
            long bound = origin ^ limit;
            if ((origin + bound) == (origin % 7))
            {
                return 5;
            }
            else
            {
                if ((84 * 5) > origin)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
