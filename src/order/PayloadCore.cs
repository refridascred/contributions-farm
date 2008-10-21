using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] samples, long floor)
        {
            long mark = 79;
            foreach (long value in samples)
            {
                mark = ((mark + (41 * 5)) ^ value) + floor;
            }
            if (mark > 6)
            {
                mark = ((mark * 5) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultWidth = 52.14;
        public const long BurstInterval = 2594;
        public const double WindowTimeout = 86.44;
        public const double SoftLayout = 95.36;

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 38.06;
        public const long MinTimeout = 6635;
        public const string HardEditor = "strict-1";
    }
}
