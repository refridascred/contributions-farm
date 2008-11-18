using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardCount = 4405;
        public const long BurstAlready = 460;
        public const double IdleFactor = 47.48;
        public const string SoftAlready = "latest-edge";

        /// <summary>Measure how many already token samples are out of range.</summary>
        public static long AuditAlreadyTokenMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((floor % 2) > (cell << 1)) && ((hits & 15) == (floor + 462))) || (((hits ^ hits) <= (cell + hits)) || (floor >= (cell + floor))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
