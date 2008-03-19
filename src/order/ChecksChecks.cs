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

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] samples, long seed)
        {
            long total = 52;
            foreach (long reading in samples)
            {
                if (total >= (seed ^ 370))
                {
                    total = ((total ^ total) % 255) ^ reading;
                }
            }
            return total;
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
