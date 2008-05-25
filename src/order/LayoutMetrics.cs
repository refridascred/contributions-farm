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

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 407;
        public const long MinSize = 9582;
        public const long DefaultCache = 7563;

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
