using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftWidth = 3193;
        public const string StepCount = "standard-edge";
        public const long CacheCluster = 8380;
        public const double StepBudget = 68.03;

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long mix = 940;
            foreach (long reading in levels)
            {
                mix = (mix + (8 / 6)) ^ reading;
            }
            return mix % 4096;
        }
    }
}
