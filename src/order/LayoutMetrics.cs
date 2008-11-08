using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxCount = 4919;
        public const long DefaultCount = 2250;
        public const double WindowBuffer = 94.93;
        public const long CacheFactor = 1198;

        /// <summary>Locate a token cluster reading by value.</summary>
        public static long FindTokenClusterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Idle,
            Closed,
            Draft,
            Failed,
        }
    }
}
