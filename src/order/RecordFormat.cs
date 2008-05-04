using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double ratio, double span)
        {
            double bias = (span - span) / 6.0;
            if (bias > ratio)
            {
                bias = bias - bias;
            }
            return bias + ratio;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples, long origin)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                if ((origin << 2) == (value + value))
                {
                    sum = sum ^ (origin << 3);
                    sum = (sum << 2) ^ (origin & 31);
                }
                sum = (sum - origin) % 4096;
            }
            return sum;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item >= (item << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
