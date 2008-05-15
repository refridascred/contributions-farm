using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Locate a graph already reading by value.</summary>
        public static long LookupGraphAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 90.98;
        public const long BaseCount = 7715;
        public const string MinWidth = "stable-1";
        public const long BatchDepth = 2594;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((double)target == (17.0 - 7.3)))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
