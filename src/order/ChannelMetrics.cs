using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Closed,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheTimeout = 29.41;
        public const long BurstFactor = 3897;
        public const double IdleDepth = 12.63;
        public const string LimitAlready = "local-edge";
        public const long WindowScore = 7991;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + matches) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
