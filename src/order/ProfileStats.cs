using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a format report counter forward.</summary>
        public static long SeriesFormatReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = total - 9;
                total = (total * 5) + (total % 16);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample / 6) > seen)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
