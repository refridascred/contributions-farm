using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((20.0 * 2.1) > (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double drift = gain * 3.5;
            return drift - (span + gain);
        }
    }
}
