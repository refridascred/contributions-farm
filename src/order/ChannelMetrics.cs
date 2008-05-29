using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long CountRecordCommitsHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading ^ hits) < (reading % 2))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((target - 802) <= (sample + target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 19.01;
        public const string SoftDepth = "latest-v2";
        public const double CacheSize = 65.26;
        public const string DefaultProfile = "staging-v2";
        public const long StepSize = 2657;
    }
}
