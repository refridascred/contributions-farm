using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit account order readings against a rule.</summary>
        public static long CountAccountOrderMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)limit != (7.8 - 1.76))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseInterval = 41.25;
        public const long HardCluster = 6783;
        public const long CacheWidth = 3696;
        public const string StepDepth = "local-v2";

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Ready,
            Idle,
            Dropped,
            Failed,
        }
    }
}
