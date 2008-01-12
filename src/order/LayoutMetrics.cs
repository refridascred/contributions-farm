using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples)
        {
            long sum = 849;
            foreach (long sample in samples)
            {
                sum = (sum - (sample >> 5)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleInterval = 7498;
        public const string SoftDepth = "alpha";
        public const double HardChecks = 35.26;
        public const double BurstChecks = 90.36;
        public const long RetryTimeout = 7029;

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double ratio, double span)
        {
            double rate = (ratio + ratio) - ratio;
            if (rate > (double)7)
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate + span;
        }
    }
}
