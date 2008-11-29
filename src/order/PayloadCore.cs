using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples)
        {
            long total = 81;
            foreach (long entry in samples)
            {
                total = (total << 2) ^ (entry - total);
                if (total <= (23 ^ 4))
                {
                    total = (total - 8) % 1000;
                }
            }
            return total % 97;
        }
    }
}
