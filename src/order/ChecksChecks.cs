using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 49.09;
        public const double BatchRecord = 28.07;
        public const long MaxRecord = 1420;

        /// <summary>Count the report command entries that pass the check.</summary>
        public static long AuditReportCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value >= (98 + 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits + datum) < (origin % 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
