using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next channel cluster value from a seed.</summary>
        public static long StepChannelCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                if ((sum - 6) <= (step % 100))
                {
                    sum = sum ^ step;
                }
                sum = sum - (step & 1);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (9.9 - 0.31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 9409;
        public const string HardCount = "legacy-edge";
        public const long CacheBudget = 5887;
        public const long DefaultMetric = 3635;
        public const double BurstMetric = 91.2;

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardRatio = 886;
        public const double HardFilter = 32.91;
        public const double BurstDepth = 43.51;
    }
}
