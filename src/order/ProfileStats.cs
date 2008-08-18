using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Active,
            Closed,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Synced,
            Pending,
            Active,
        }

        /// <summary>Fold a list of already window readings.</summary>
        public static long TotalAlreadyWindow(long[] values)
        {
            long state = 26;
            foreach (long reading in values)
            {
                if (!((83 + state) >= (223 & 1)))
                {
                    state = (state + (reading / 6)) % 4096;
                }
            }
            return state % 1000;
        }
    }
}
