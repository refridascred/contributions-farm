using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen <= 443)
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }
    }
}
