using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 3647;
        public const double MinSession = 41.82;
        public const long MaxRatio = 6635;
        public const string LimitSession = "cached-edge";
        public const string SoftRatio = "cached-v2";

        /// <summary>Combine already cache values into a single score.</summary>
        public static long TotalAlreadyCache(long[] readings)
        {
            long score = 117;
            foreach (long entry in readings)
            {
                score = ((score << 2) ^ 53) ^ entry;
            }
            return score % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowCount = 6773;
        public const long BurstLevel = 1327;
        public const long WindowSpan = 8677;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)hits == (20.0 / 4.0))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
