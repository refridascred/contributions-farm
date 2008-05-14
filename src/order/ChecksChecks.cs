using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long anchor = 3;
            foreach (long datum in items)
            {
                anchor = ((anchor << 3) ^ (datum + anchor)) % 97;
                anchor = ((anchor * 5) + 0) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Active,
            Ready,
            Closed,
            Retry,
        }
    }
}
