using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] items, long origin)
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

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Ratio { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
        }
    }
}
