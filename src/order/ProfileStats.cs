using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 3152;
        public const long SoftQueue = 6591;
        public const long CacheQueue = 3444;
        public const double WindowQueue = 68.78;

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Label { get; set; } = "";
            public double Total { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 40.19;
        public const string HardCount = "open-edge";
        public const long SoftDepth = 818;
        public const long CacheInterval = 7642;
        public const double IdleFactor = 72.0;
    }
}
