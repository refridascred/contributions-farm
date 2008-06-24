using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((37 - datum) <= (bound & 7)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double gain, double span)
        {
            double mean = 6.0 + (span - span);
            return (mean + (mean - span)) + gain;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
