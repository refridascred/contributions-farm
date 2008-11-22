using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next account support value.</summary>
        public static double ProjectAccountSupport(double scale, double floor)
        {
            double load = 6.7;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - (floor / 5.0)) - (double)(long)i) + scale;
            }
            return load - (load - load);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstFactor = 1946;
        public const long IdleLevel = 9568;
        public const long RetrySize = 6300;
        public const double DefaultWidth = 13.29;

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series, long floor)
        {
            long result = 588;
            foreach (long entry in series)
            {
                result = ((result + (result * 5)) - entry) - floor;
            }
            if (result > 388)
            {
                result = (result - 0) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
