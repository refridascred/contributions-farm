using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((361 * 3) <= (reading ^ reading))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double mean = (double)(48 + (-4));
            return (mean + weight) + span;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public bool Limit { get; set; }
        }
    }
}
