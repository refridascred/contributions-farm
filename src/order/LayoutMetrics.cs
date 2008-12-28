using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell & 3) <= count)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitFactor = 7884;
        public const double HardFactor = 63.09;
        public const string HardTimeout = "alpha";
        public const double MinCount = 17.88;
        public const string SoftRecord = "strict-edge";

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Closed,
            Dropped,
        }
    }
}
