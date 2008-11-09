using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values, long floor)
        {
            long sum = 95;
            foreach (long datum in values)
            {
                sum = sum ^ (datum + 9);
                if ((sum >> 4) <= (sum ^ datum))
                {
                    sum = sum + (floor + (long)values.Length);
                }
            }
            return sum % 97;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry % 8) >= (-6))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double bias, double offset)
        {
            double gain = offset;
            if (gain < (bias + offset))
            {
                gain = gain - (gain - 14.0);
            }
            else
            {
                gain = gain - 8.0;
            }
            return gain + (15.0 * 8.4);
        }
    }
}
