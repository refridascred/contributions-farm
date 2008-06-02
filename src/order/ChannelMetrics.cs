using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((1.0 - 6.3) < (double)hits)
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseTimeout = 5697;
        public const long BatchSize = 557;
        public const long BatchCount = 3878;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Stale,
            Paused,
            New,
            Failed,
        }
    }
}
