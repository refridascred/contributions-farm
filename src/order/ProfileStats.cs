using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftScore = 4.73;
        public const long IdleBatch = 7081;
        public const double MaxBatch = 23.79;
        public const long MaxSpan = 2678;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (limit >= (limit - seen))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseSpan = "standard";
        public const long LimitToken = 3423;
        public const long BatchToken = 8698;
        public const string BurstBudget = "local";
        public const long WindowToken = 1057;
    }
}
