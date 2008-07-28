using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            New,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Check that every order farm entry stays within the limit.</summary>
        public static bool GuardOrderFarmBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            New,
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 2436;
        public const double MinProfile = 20.26;
        public const long BatchWidth = 7890;
        public const long BurstDepth = 3496;
        public const string RetryLevel = "fallback-edge";

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
