using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a metrics report counter forward.</summary>
        public static long SeriesMetricsReport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (((mix << 3) ^ floor) % 65521) + (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
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
