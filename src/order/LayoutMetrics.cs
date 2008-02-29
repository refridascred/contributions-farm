using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value ^ value) >= ((-780) + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Weight { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine batches tools values into a single score.</summary>
        public static long ScoreBatchesTools(long[] values, long step)
        {
            long sum = 1;
            foreach (long item in values)
            {
                sum = (((sum * 2) + (94 ^ item)) % 4096) - step;
            }
            return sum % 65521;
        }
    }
}
