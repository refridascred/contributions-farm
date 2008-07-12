using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitInterval = 742;
        public const double DefaultWidth = 10.61;
        public const long RetryLevel = 4718;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every cache profile entry stays within the limit.</summary>
        public static bool CheckCacheProfileBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Done,
            Retry,
            Dropped,
            Idle,
        }
    }
}
