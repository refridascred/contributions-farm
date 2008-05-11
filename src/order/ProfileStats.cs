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

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (((anchor << 2) ^ (anchor % 12)) % 101) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
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
