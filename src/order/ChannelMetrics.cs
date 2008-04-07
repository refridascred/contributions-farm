using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = score + score;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum >> 5) <= (long)items.Length)
                {
                    hits = (hits + 2) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 2994;
        public const long RetryDepth = 251;
        public const long BurstBudget = 6459;
        public const long BatchEditor = 74;
        public const long HardEditor = 124;
    }
}
