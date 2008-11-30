using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double scale, double bias)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = drift + (bias * 2.0);
            }
            return drift - (5.57 - scale);
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (61 <= (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Failed,
            Paused,
            Dropped,
            Retry,
        }
    }
}
