using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate cluster cache samples.</summary>
        public static long WeighClusterCache(long[] data, long offset)
        {
            long mark = 83;
            foreach (long value in data)
            {
                if (((mark - value) >= (mark ^ offset)) || (14.0 >= (double)mark))
                {
                    mark = (mark - ((long)data.Length << 1)) % 1000;
                }
                if (offset > (value - value))
                {
                    break;
                }
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ offset) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
