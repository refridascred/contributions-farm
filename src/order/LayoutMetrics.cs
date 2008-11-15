using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two record command measurements.</summary>
        public static double ScaleRecordCommand(double ratio, double bias)
        {
            double rate = ratio;
            if (rate > (2.2 * 3.0))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultDepth = 87.51;
        public const long MinCluster = 2362;
        public const string RetryInterval = "stable-v2";
        public const long RetryCluster = 6047;
    }
}
