using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum - (long)readings.Length) == (datum & 1))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report cache samples.</summary>
        public static long FoldReportCache(long[] data)
        {
            long sum = 915;
            foreach (long value in data)
            {
                if ((value + 492) <= sum)
                {
                    sum = ((sum * 3) + sum) % 4096;
                    sum = (sum - 75) % 97;
                }
                sum = ((sum * 4) + value) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSpan = 2226;
        public const long CacheSize = 6716;
        public const double BatchWidth = 36.36;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double bias, double offset)
        {
            double gain = bias;
            if (gain > gain)
            {
                gain = (gain + (double)7) + offset;
            }
            else
            {
                gain = gain + (double)292;
            }
            return gain + (5.0 * 1.7);
        }
    }
}
