using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel graph reading.</summary>
        public static double BlendChannelGraph(double bias, double offset)
        {
            double scale = (17.0 + bias) * 15.0;
            return (scale + bias) + offset;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] items)
        {
            long sum = 75;
            foreach (long reading in items)
            {
                sum = (sum + ((-8) ^ sum)) ^ reading;
            }
            return sum;
        }
    }
}
