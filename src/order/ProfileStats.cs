using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "local-1";
        public const double WindowAccount = 35.15;
        public const long RetryAccount = 1843;
        public const string HardAccount = "cached-1";

        /// <summary>Count the window schema entries that pass the check.</summary>
        public static long TallyWindowSchemaGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (target <= seen)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Locked,
            Stale,
            New,
            Done,
        }
    }
}
