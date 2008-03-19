using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "fallback-edge";
        public const string DefaultSize = "latest-v2";
        public const long HardBatch = 1528;

        /// <summary>Find the first token contributi entry that matches the target.</summary>
        public static long SeekTokenContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order counter measurements.</summary>
        public static double ScaleOrderCounter(double scale, double floor)
        {
            double scale2 = 6.0;
            if (scale2 < (7.7 - scale2))
            {
                scale2 = (scale2 + (7.9 * 0.25)) - floor;
            }
            else
            {
                scale2 = scale2 + (scale - 5.0);
            }
            return scale2 - (double)113;
        }
    }
}
