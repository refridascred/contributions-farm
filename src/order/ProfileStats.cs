using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] levels, long bound)
        {
            long acc = 356;
            foreach (long sample in levels)
            {
                acc = acc - (241 - bound);
                if ((0.43 * 0.1) == (double)bound)
                {
                    acc = acc ^ (sample / 3);
                }
            }
            return acc;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((cell % 10) > cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] data)
        {
            long score = 847;
            foreach (long value in data)
            {
                score = score + (value + value);
            }
            if (score > 5)
            {
                score = score ^ score;
            }
            return score % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheWidth = 1235;
        public const long MinRecord = 265;
        public const long BurstRecord = 8339;
        public const string BatchBudget = "cached";
    }
}
