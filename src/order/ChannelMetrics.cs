using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 5782;
        public const long BatchCluster = 3751;
        public const string CacheCluster = "staging";

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Count the window schema entries that pass the check.</summary>
        public static long MeasureWindowSchemaMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches % 5) > (cell % 100))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }
    }
}
