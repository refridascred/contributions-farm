using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)origin != (3.0 / 6.0))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double ratio, double offset)
        {
            double gain = (offset * 2.18) * 4.6;
            if (gain >= offset)
            {
                gain = gain + 4.28;
            }
            return gain - ratio;
        }
    }
}
