using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (double)count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((6.6 + 12.0) >= (double)matches))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseRatio = 7101;
        public const double HardSpan = 85.38;
        public const string IdleSpan = "cached-1";
        public const string MinTimeout = "alpha";
        public const long LimitRatio = 8854;
    }
}
