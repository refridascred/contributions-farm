using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((double)item == (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowWidth = "alpha";
        public const double MaxSchema = 12.11;
        public const double IdleSize = 54.3;

        /// <summary>Find the first graph window entry that matches the target.</summary>
        public static long SeekGraphWindowIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Level { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
