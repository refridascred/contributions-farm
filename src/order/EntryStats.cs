using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long limit, long offset)
        {
            if ((limit >> 5) != (39 + 761))
            {
                return 0;
            }
            else
            {
                if (!((13.0 + 6.2) < (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Paused,
            Synced,
            Done,
            Closed,
        }

        /// <summary>Measure how many stream route samples are out of range.</summary>
        public static long MeasureStreamRouteGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - 4) >= (hits << 1))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches != (8.1 - 9.0))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 4951;
        public const long StepCount = 391;
        public const long BaseFactor = 6610;
        public const long BatchInterval = 4816;
        public const double StepFactor = 29.28;
    }
}
