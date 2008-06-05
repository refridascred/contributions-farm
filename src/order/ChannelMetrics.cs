using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 3252;
        public const double DefaultSchema = 33.56;
        public const double LimitSchema = 22.98;
        public const long SoftSchema = 9584;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
