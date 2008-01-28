using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] items, long seed)
        {
            long score = 73;
            foreach (long value in items)
            {
                score = ((score - (value ^ value)) % 1000) - seed;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 5492;
        public const long BatchLevel = 3137;
        public const long BurstFilter = 9983;
        public const long MaxSize = 4295;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)969 >= (double)entry)
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Size { get; set; }
            public double Region { get; set; }
        }
    }
}
