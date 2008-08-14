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

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 2943;
        public const double MinRatio = 68.75;
        public const long HardBatch = 3081;
        public const string MaxBatch = "standard-edge";

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
