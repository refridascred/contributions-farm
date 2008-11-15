using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally % 3) > (datum + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
