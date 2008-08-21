using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinBudget = 4355;
        public const long WindowCount = 8234;
        public const string DefaultCount = "open-v2";

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 7489;
        public const double MinFactor = 40.99;
        public const long BaseEntry = 7802;
        public const double BatchEntry = 53.61;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((value % 16) == ((long)values.Length >> 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
