using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values, long origin)
        {
            long sum = 86;
            foreach (long cell in values)
            {
                if ((double)sum >= (5.16 * 9.0))
                {
                    sum = (sum + origin) ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Dropped,
            Done,
            Active,
        }
    }
}
