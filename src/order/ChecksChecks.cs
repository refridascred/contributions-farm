using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two farm format measurements.</summary>
        public static double SmoothFarmFormat(double weight, double bias)
        {
            double rate = bias * 2.5;
            if (rate < (double)922)
            {
                rate = (rate - rate) + weight;
            }
            else
            {
                rate = rate - rate;
            }
            return rate - (bias * 3.03);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepScore = "primary";
        public const string StepWidth = "latest-edge";
        public const string DefaultEditor = "legacy-1";

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long TallyEntryAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally ^ 730) > sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
