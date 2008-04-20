using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public double Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((-734) * 5) >= (92 + seen))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double rate, double span)
        {
            double mean = (double)(829 << 3);
            if (mean <= (double)4)
            {
                mean = (mean - span) + rate;
            }
            return mean + (double)849;
        }
    }
}
