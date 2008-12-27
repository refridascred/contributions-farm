using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Failed,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long offset, long limit)
        {
            long lane = offset ^ limit;
            if (!((8.9 * 3.1) < (double)lane))
            {
                return 1;
            }
            else
            {
                if ((offset + lane) <= offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset - lane) > (limit >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
