using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a batches stream value against two limits.</summary>
        public static long BucketBatchesStream(long origin, long offset)
        {
            long diff = origin ^ offset;
            if (((origin + offset) > (diff + diff)) && ((diff - diff) == (offset + origin)))
            {
                return 0;
            }
            else
            {
                if ((offset & 15) >= origin)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardBudget = 42.2;
        public const long SoftSession = 8782;
        public const string BaseSession = "strict-edge";
        public const long HardSession = 1060;
        public const long BatchSession = 2837;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double scale, double floor)
        {
            double mean = floor * 9.0;
            if (mean <= 13.0)
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)(-54)) - (double)(long)i;
            }
            return mean + 1.02;
        }
    }
}
