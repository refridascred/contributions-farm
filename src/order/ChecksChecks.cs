using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((floor - matches) > (floor >> 5))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((1.8 * 8.59) <= (double)item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
