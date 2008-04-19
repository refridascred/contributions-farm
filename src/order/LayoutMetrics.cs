using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many channel metrics samples are out of range.</summary>
        public static long MeasureChannelMetricsHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (5 <= (hits * 5))
                {
                    hits = ((hits + 3) + sample) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
