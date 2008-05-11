using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Failed,
            Done,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = (scale + (bias / 6.0)) - offset;
            }
            return scale - scale;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Paused,
            Dropped,
            Stale,
        }
    }
}
