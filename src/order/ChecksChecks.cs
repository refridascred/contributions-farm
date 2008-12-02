using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a tools session sample.</summary>
        public static long LocateToolsSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }
    }
}
