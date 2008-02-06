using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitRatio = 5448;
        public const string LimitInterval = "latest-v2";
        public const long MaxEntry = 4278;
        public const long SoftLevel = 5357;
        public const double IdleEntry = 43.55;

        /// <summary>Compare every pair of buffer entry readings.</summary>
        public static long CompareBufferEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double scale, double bias)
        {
            double ratio = (double)(87 ^ 3);
            if (ratio <= scale)
            {
                ratio = ratio + (bias / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (bias - 17.0)) + (double)(long)i;
            }
            return ratio - (7.38 / 9.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowTimeout = "legacy";
        public const long StepDepth = 7222;
        public const long RetryFilter = 5403;
    }
}
