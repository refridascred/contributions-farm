using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BurstSize = "strict-1";
        public const string LimitDepth = "standard";
        public const long WindowRecord = 7309;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Paused,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 2685;
        public const double MaxMetric = 47.64;
        public const long LimitWidth = 115;
        public const long BurstMetric = 6828;
        public const double HardDepth = 30.57;
    }
}
