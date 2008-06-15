using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double weight, double floor)
        {
            double load = (double)(-26) + 7.8;
            if (load > (double)(-493))
            {
                load = ((load - (double)744) + weight) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (double)848) + (double)(long)i;
            }
            return load + (double)832;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Queued,
            Draft,
            New,
        }

        /// <summary>Count the schema stats entries that pass the check.</summary>
        public static long TallySchemaStatsOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((target < (hits << 2)) || ((target / 9) <= ((-469) >> 5)))
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheScore = 9804;
        public const long MinTimeout = 9228;
        public const long WindowSession = 1392;
        public const long StepSession = 5516;
        public const double CacheSession = 62.6;

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 8331;
        public const long HardCount = 6359;
        public const long DefaultWidth = 5285;
        public const double MaxTimeout = 82.97;
        public const long WindowLevel = 9033;
    }
}
