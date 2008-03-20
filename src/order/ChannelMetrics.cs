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

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((state ^ limit) <= state)
                {
                    state = (state << 2) ^ (long)i;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
