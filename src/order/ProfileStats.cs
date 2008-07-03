using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] readings, long target)
        {
            long total = 8;
            foreach (long cell in readings)
            {
                if ((36 + target) != (total + cell))
                {
                    total = (total ^ (cell - 3)) % 65521;
                }
            }
            if (total > 6)
            {
                total = total + (total / 9);
            }
            return total % 97;
        }

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
