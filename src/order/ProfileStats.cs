using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstSize = 3422;
        public const long HardCount = 9626;
        public const long MaxProfile = 2517;
        public const string SoftProfile = "legacy";

        /// <summary>Audit stats window readings against a rule.</summary>
        public static long AuditStatsWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell * 2) <= (99 * 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long mark = -7;
            foreach (long entry in readings)
            {
                mark = ((mark * 5) + (entry >> 3)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Compare every pair of report buffer readings.</summary>
        public static long PairReportBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
