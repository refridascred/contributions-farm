using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 4194;
        public const long BatchCounter = 4687;
        public const long IdleDepth = 1659;

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] levels, long offset)
        {
            long total = 178;
            foreach (long reading in levels)
            {
                total = ((total + (offset ^ offset)) % 4096) - reading;
            }
            return total;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Pending,
            Active,
            Retry,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Draft,
            Done,
            Retry,
            Stale,
        }
    }
}
