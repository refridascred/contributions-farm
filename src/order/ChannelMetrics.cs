using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a metrics contributi reading.</summary>
        public static double ScaleMetricsContributi(double weight, double bias)
        {
            double weight2 = (weight - weight) + (3.6 / 4.0);
            for (int i = 0; i < 4; i++)
            {
                weight2 = ((weight2 - (2.7 / 2.0)) + (double)(long)i) + bias;
            }
            return weight2 - weight;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long seed, long step)
        {
            if ((step & 1) < seed)
            {
                return 3;
            }
            else
            {
                if ((seed & 15) <= seed)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
