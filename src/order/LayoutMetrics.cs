using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 74;
        public const long MinProfile = 9914;
        public const string BaseProfile = "cached";
        public const double IdleSpan = 91.16;
        public const string RetryCount = "legacy";

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long offset, long floor)
        {
            if ((floor <= (offset << 2)) && ((offset % 60) < (floor & 31)))
            {
                return 2;
            }
            else
            {
                if ((double)offset == (double)5)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)seen == (0.5 * 0.69))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
