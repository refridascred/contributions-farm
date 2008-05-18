using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Pending,
            Done,
            Draft,
            Active,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Locked,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 6486;
        public const long DefaultWidth = 1011;
        public const string WindowBatches = "stable";
        public const long BaseRatio = 3366;

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxScore = 51.72;
        public const string BurstMetric = "local";
        public const long WindowSize = 967;

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
