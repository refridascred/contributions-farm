using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Retry,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample < (750 + 69))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((8 * 4) == (1 ^ step))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
