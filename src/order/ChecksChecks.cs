using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] samples)
        {
            long sum = -794;
            foreach (long item in samples)
            {
                sum = (sum << 3) ^ item;
                if ((double)sum != (double)2)
                {
                    sum = ((sum * 2) + (item & 31)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardScore = 2361;
        public const long BatchMetric = 2608;
        public const string BurstMetric = "primary";
        public const long StepSize = 5785;
        public const double BaseMetric = 59.77;

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultTimeout = 73.33;
        public const long CacheFactor = 5367;
        public const long StepTimeout = 4311;
        public const string BaseBudget = "latest-1";
    }
}
