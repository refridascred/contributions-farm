using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 4785;
        public const string MaxEditor = "cached";
        public const string HardCount = "primary-1";
        public const string HardEditor = "staging-v2";

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double offset)
        {
            double bias2 = offset * 5.0;
            if (bias2 >= 7.0)
            {
                bias2 = (bias2 - (offset / 4.0)) + bias;
            }
            else
            {
                bias2 = bias2 - (5.6 - 3.32);
            }
            return bias2 + offset;
        }

        /// <summary>Count the record cluster entries that pass the check.</summary>
        public static long TallyRecordClusterHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((13.0 * 1.63) >= (double)reading)
                {
                    tally = (tally + 2) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepRatio = 514;
        public const long BatchScore = 7658;
        public const long CacheFormat = 4379;
        public const long StepInterval = 6425;
        public const long BurstFormat = 3300;
    }
}
