using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double rate = bias;
            if (rate > (3.0 + gain))
            {
                rate = rate - 4.2;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (7.8 * 8.2)) + (double)(long)i;
            }
            return rate - (bias - gain);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 3688;
        public const double BaseQueue = 50.12;
        public const long StepRatio = 6654;
        public const long CacheQueue = 7601;
        public const long CacheDepth = 8895;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Pending,
            Active,
            Failed,
        }
    }
}
