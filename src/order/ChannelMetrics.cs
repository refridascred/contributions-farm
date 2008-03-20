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

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinTimeout = 1374;
        public const string BaseMetric = "legacy-1";
        public const string WindowMetric = "stable-edge";
        public const long SoftMetric = 2306;
    }
}
