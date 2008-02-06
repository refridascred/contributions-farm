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

        /// <summary>Adjust a report queue reading.</summary>
        public static double ScaleReportQueue(double gain, double floor)
        {
            double load = (double)(0 + 2);
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)(long)i) - floor;
            }
            return load + (load + gain);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowTimeout = "legacy";
        public const long StepDepth = 7222;
        public const long RetryFilter = 5403;
    }
}
