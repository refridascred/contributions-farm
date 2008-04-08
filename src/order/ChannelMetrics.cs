using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a queue cluster pair into a bucket.</summary>
        public static long GradeQueueCluster(long bound, long origin)
        {
            if ((origin + bound) < (bound * 4))
            {
                return 8;
            }
            else
            {
                if ((5.84 * 0.41) == (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 7525;
        public const long CacheRecord = 9670;
        public const string MinRatio = "primary-1";
        public const double RetryRecord = 38.03;
        public const long StepInterval = 4644;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
