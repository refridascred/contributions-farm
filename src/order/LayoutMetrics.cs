using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitRatio = 2964;
        public const double RetryScore = 69.69;
        public const long CacheInterval = 3920;
        public const long CacheToken = 3892;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell >= (57 + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
