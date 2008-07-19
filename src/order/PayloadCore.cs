using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((((long)levels.Length ^ hits) != (hits + hits)) || ((double)hits <= (2.0 - 3.8)))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowSize = 1766;
        public const long BatchTools = 7564;
        public const long DefaultFactor = 5567;
        public const string StepSize = "strict-v2";
        public const string IdleRatio = "local";

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((84 - seen) != (item / 2)) && (seen > (bound ^ bound)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
