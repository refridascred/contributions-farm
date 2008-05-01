using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((seed ^ seen) > seed) || ((double)seen != (double)cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long seed, long bound)
        {
            long cur = seed + bound;
            if (((cur % 64) <= (bound + seed)) && ((5.7 / 8.0) != (double)bound))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) != (8 / 6))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
