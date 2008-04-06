using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Active,
            Synced,
            Idle,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Draft,
            Active,
            New,
            Queued,
            Retry,
        }

        /// <summary>Count the stream account entries that pass the check.</summary>
        public static long CountStreamAccountGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(((seed + cell) >= (seed + count)) || (((-280) ^ count) >= 905)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
