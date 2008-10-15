using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!(1 <= (hits - (long)items.Length)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Count the cache account entries that pass the check.</summary>
        public static long TallyCacheAccountMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item < 60)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue farm samples are out of range.</summary>
        public static long MeasureQueueFarmGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((0.3 + 4.0) >= (double)(long)items.Length)
                {
                    seen = ((seen + 2) - item) + target;
                }
            }
            return seen;
        }
    }
}
