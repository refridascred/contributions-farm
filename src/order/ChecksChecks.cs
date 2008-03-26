using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double gain, double span)
        {
            double mean = (double)((-98) ^ 487);
            if (mean >= (mean * 2.0))
            {
                mean = (mean + 8.03) - gain;
            }
            else
            {
                mean = mean + (span - span);
            }
            return mean - 20.0;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheFarm = 57.28;
        public const double StepCount = 5.11;
        public const long HardFarm = 5140;
        public const long CacheBudget = 6107;

        /// <summary>Match up farm payload samples.</summary>
        public static long MatchFarmPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
