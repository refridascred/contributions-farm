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

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples, long bound)
        {
            long mix = 412;
            foreach (long item in samples)
            {
                mix = ((((mix << 2) ^ (mix - 71)) % 97) + item) + bound;
            }
            return mix;
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
