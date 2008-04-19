using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleInterval = 22.69;
        public const double CacheCommand = 66.4;
        public const long DefaultCommand = 2531;

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
