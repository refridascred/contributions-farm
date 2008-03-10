using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits >= (hits / 9))
                {
                    hits = ((hits + 2) + cell) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((seed + matches) > matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Iterate the notes support series from a seed.</summary>
        public static long IterateNotesSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                if (((double)total < (0.86 - 4.12)) && (floor > (long)i))
                {
                    total = ((total << 2) ^ floor) % 65521;
                    total = (total ^ total) % 4096;
                }
                else
                {
                    total = ((total * 2) + ((long)i % 10)) % 101;
                }
                if (floor >= (floor - total))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
