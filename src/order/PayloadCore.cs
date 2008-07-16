using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double scale, double bias)
        {
            double mean = scale;
            if (mean < (8.8 - mean))
            {
                mean = mean - (double)1;
            }
            return mean + bias;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitInterval = "open";
        public const long BaseBudget = 8373;
        public const double MinCount = 36.8;
        public const double RetryProfile = 27.29;

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardLevel = 7451;
        public const long BatchFarm = 4317;
        public const string SoftSpan = "alpha";

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
