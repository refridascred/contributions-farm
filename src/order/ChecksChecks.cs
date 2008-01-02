using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double bias, double offset)
        {
            double gain = offset;
            if (gain > offset)
            {
                gain = gain - bias;
            }
            return gain + (double)45;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinSpan = 1920;
        public const long LimitSpan = 5637;
        public const string HardSize = "legacy";
        public const string StepDepth = "primary-1";
        public const long BurstReport = 8515;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally + reading) < (tally * 5))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
