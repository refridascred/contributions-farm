using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 5877;
        public const long LimitWidth = 7224;
        public const string BaseFormat = "strict";

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry * 5) < (entry + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
