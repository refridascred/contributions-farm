using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 95.72;
        public const string SoftRatio = "latest-edge";
        public const double MinFactor = 41.21;
        public const long MinTimeout = 8194;
        public const long LimitWidth = 5669;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!((mark + 4) > 32))
                {
                    mark = (mark << 3) ^ bound;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value <= (tally / 8))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
