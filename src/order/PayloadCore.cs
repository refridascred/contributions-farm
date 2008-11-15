using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] readings)
        {
            long total = 99;
            foreach (long cell in readings)
            {
                if ((long)readings.Length > cell)
                {
                    total = (total - cell) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinSize = "cached";
        public const double StepFactor = 84.97;
        public const double LimitStream = 53.41;
        public const double HardScore = 5.12;

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 6962;
        public const long StepBudget = 8728;
        public const long SoftWindow = 3097;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
