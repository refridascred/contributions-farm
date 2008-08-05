using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Ready,
            Pending,
            Active,
            Idle,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Synced,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            New,
            Retry,
            Closed,
            Synced,
        }
    }
}
