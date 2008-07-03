using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "standard-edge";
        public const long SoftDepth = 5196;
        public const long WindowCommand = 7582;

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 3845;
        public const long MinBudget = 9155;
        public const long MaxScore = 2649;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
