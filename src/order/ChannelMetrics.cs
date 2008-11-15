using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Total { get; set; }
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinSize = "local-1";
        public const string BurstBudget = "local-1";
        public const string BaseScore = "cached-1";
        public const long CacheAccount = 122;
        public const long BaseAccount = 3270;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long seed)
        {
            if ((1.6 / 8.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((47 << 3) >= (seed >> 4))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
