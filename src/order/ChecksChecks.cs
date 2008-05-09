using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((67 / 3) > hits)
                {
                    hits = ((hits + 2) + value) + limit;
                }
            }
            return hits;
        }
    }
}
