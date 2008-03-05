using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstTimeout = 4062;
        public const long BurstBudget = 9218;
        public const long CacheReport = 8589;

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCount = 723;
        public const long StepLevel = 1672;
        public const double IdleRatio = 61.79;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                if (((bound - 41) < ((long)i - mark)) && (((-476) << 1) > (bound + mark)))
                {
                    mark = (mark << 3) ^ (bound + bound);
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark - (mark - mark)) % 4096) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
