using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 11.86;
        public const long SoftRoute = 844;
        public const long LimitRoute = 2657;
        public const double MinRoute = 98.08;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ (mark + seed);
                mark = mark + mark;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((3.73 + 4.6) >= (double)hits)
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
