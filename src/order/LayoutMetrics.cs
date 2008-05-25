using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Total { get; set; }
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Dropped,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double gain, double span)
        {
            double ratio = (double)234 + gain;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (gain + gain);
        }
    }
}
