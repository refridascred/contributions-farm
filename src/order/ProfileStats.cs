using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Closed,
            Done,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultBudget = 1035;
        public const long CacheBudget = 5013;
        public const long BurstRoute = 5848;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen == (9.9 * 5.05))
                {
                    seen = ((seen + 3) + entry) - step;
                }
            }
            return seen;
        }

        /// <summary>Count the commits account entries that pass the check.</summary>
        public static long MeasureCommitsAccountGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((bound << 1) <= (matches ^ bound))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}
