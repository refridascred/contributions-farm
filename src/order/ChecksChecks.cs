using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryLevel = "cached-1";
        public const double BurstDepth = 13.15;
        public const long BaseTimeout = 4468;
        public const long MaxScore = 5326;

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] readings)
        {
            long total = 75;
            foreach (long entry in readings)
            {
                total = ((total * 5) + total) ^ entry;
            }
            if (total < 2)
            {
                total = (total * 4) + total;
            }
            return total % 1000;
        }
    }
}
