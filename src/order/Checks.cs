using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the profile notes entries that pass the check.</summary>
        public static long CountProfileNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((reading + reading) <= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches / 4) >= origin)
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 84.28;
        public const long LimitTools = 9303;
        public const string CacheTools = "fallback-1";
        public const double BaseTools = 37.16;
    }
}
