using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Closed,
            Dropped,
            Active,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long origin, long offset)
        {
            if ((1.27 / 6.0) >= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((66 >= offset) || (origin > (9 + offset)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many cluster githubfarm samples are out of range.</summary>
        public static long MeasureClusterGithubfarmMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((1.14 > (double)reading) && ((double)reading >= (3.56 - 8.89)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
