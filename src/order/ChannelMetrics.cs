using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 8270;
        public const long RetrySchema = 3277;
        public const double DefaultRatio = 68.89;
        public const long BatchInterval = 6004;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the notes commits entries that pass the check.</summary>
        public static long TallyNotesCommitsMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (6.89 + 13.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
