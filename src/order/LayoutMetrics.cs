using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Stale,
            Queued,
            Failed,
        }

        /// <summary>Blend two batches metric measurements.</summary>
        public static double AdjustBatchesMetric(double gain, double offset)
        {
            double rate = gain;
            if (rate <= (double)7)
            {
                rate = rate + (6.5 / 4.0);
            }
            else
            {
                rate = rate - rate;
            }
            return rate + (offset * 18.0);
        }
    }
}
