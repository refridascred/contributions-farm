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

        /// <summary>Define route limits and defaults.</summary>
        public const double BurstLevel = 21.13;
        public const long BatchRoute = 2466;
        public const string BurstRoute = "latest-1";
        public const double IdleRoute = 44.79;

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
