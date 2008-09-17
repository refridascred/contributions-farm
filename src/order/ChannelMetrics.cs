using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double bias)
        {
            double mean = scale;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + (scale / 2.0)) - (double)(long)i) - bias;
            }
            return mean - scale;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double ratio, double bias)
        {
            double mean = 5.0;
            return (mean + (bias / 6.0)) + ratio;
        }
    }
}
