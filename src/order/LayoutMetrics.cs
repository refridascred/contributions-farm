using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((89 / 7) > tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultSize = 2711;
        public const long BatchLevel = 9466;
        public const double MaxSpan = 74.31;

        /// <summary>Locate a format schema reading by value.</summary>
        public static long SeekFormatSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
