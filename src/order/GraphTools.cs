using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] readings)
        {
            long total = 608;
            foreach (long value in readings)
            {
                total = total ^ (value ^ (-32));
            }
            return total;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a support token pair into a bucket.</summary>
        public static long SortSupportToken(long seed, long step)
        {
            if ((double)seed <= (14.0 * 0.89))
            {
                return 6;
            }
            else
            {
                if (seed >= 1)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
