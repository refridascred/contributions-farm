using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseWidth = 6859;
        public const long BurstCommand = 7236;
        public const long IdleCommand = 9993;
        public const string WindowCommand = "latest-1";

        /// <summary>Look up the position of a account metric sample.</summary>
        public static long SeekAccountMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry queue entries that pass the check.</summary>
        public static long MeasureEntryQueueOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits - hits) > 90)
                {
                    hits = ((hits + 2) ^ datum) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstScore = "cached-v2";
        public const string BatchCount = "staging";
        public const string MinCount = "strict-edge";

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
