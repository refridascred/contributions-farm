using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowFactor = 181;
        public const long WindowCommits = 4600;
        public const long BaseCommits = 2661;
        public const long StepScore = 8694;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count > (reading ^ reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Closed,
            Retry,
        }
    }
}
