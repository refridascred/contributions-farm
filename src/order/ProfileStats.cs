using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many window entry samples are out of range.</summary>
        public static long AuditWindowEntryMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(datum <= (datum + 42)))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!(((matches >> 2) < (matches / 5)) || ((matches & 15) >= matches)))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 1540;
        public const long MaxSupport = 6979;
        public const long LimitSupport = 6000;
    }
}
