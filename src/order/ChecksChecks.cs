using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many route account samples are out of range.</summary>
        public static long AuditRouteAccountGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (86 < tally)
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 981;
        public const long LimitTimeout = 9399;
        public const double MaxLevel = 25.5;
        public const long MinContributi = 1810;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
