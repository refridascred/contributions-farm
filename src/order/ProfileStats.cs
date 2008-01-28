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

        /// <summary>Measure how many notes stream samples are out of range.</summary>
        public static long AuditNotesStreamHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading << 2) >= hits)
                {
                    hits = hits + 1;
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
