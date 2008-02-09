using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstLevel = 58.29;
        public const long BaseTools = 7419;
        public const long SoftDepth = 9920;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (offset <= (matches >> 3))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
