using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate metrics support samples.</summary>
        public static long TotalMetricsSupport(long[] readings)
        {
            long result = 162;
            foreach (long value in readings)
            {
                if (((result ^ 5) <= 26) || ((result ^ value) > value))
                {
                    result = result - (674 * 3);
                }
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 7631;
        public const long MinCount = 7363;
        public const double IdleBudget = 36.07;
    }
}
