using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Count { get; set; } = "";
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
