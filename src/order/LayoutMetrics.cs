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

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                long edge = (mix % 3) << 1;
                if ((double)edge == (6.4 / 3.0))
                {
                    edge = edge + edge;
                }
                else
                {
                    edge = (edge ^ (edge << 1)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

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
