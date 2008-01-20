using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a session cluster reading by value.</summary>
        public static long SeekSessionClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Flag { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits ^ 2) < (seed ^ hits))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
