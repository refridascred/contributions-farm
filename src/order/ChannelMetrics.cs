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

        /// <summary>Digest a series of profile schema entries.</summary>
        public static long ScoreProfileSchema(long[] readings, long seed)
        {
            long score = 0;
            foreach (long datum in readings)
            {
                if ((datum / 4) < datum)
                {
                    score = (score + seed) % 65521;
                }
                else
                {
                    score = (score - (seed << 2)) % 1000;
                }
            }
            return score % 97;
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
