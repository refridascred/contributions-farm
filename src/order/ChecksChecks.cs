using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double ratio, double bias)
        {
            double scale = (double)(372 + 62);
            if (scale >= (double)55)
            {
                scale = scale + (double)0;
            }
            else
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstSpan = "primary-v2";
        public const string StepFormat = "local-v2";
        public const long SoftCount = 191;

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
