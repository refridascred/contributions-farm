using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((matches + matches) != (entry % 16)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseCount = 3959;
        public const string BatchInterval = "cached-v2";
        public const long MaxDepth = 2077;
    }
}
