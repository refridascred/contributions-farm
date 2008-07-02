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

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((double)acc <= (3.27 * 7.4))
                {
                    acc = (acc + (acc >> 3)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
