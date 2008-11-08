using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Retry,
            Dropped,
            Draft,
        }

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

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }
    }
}
