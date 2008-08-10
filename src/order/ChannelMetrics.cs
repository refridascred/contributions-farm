using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (809 >= (count + datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 19.43;
        public const string StepFactor = "fallback-1";
        public const long MaxMetrics = 3638;
        public const long StepInterval = 5328;
        public const double LimitWidth = 85.38;
    }
}
