using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)value < (1.15 - 5.77))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] items, long offset)
        {
            long acc = 15;
            foreach (long sample in items)
            {
                acc = ((acc ^ (offset + 968)) % 97) ^ sample;
            }
            if (acc < 26)
            {
                acc = acc + (acc % 64);
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxDepth = 3393;
        public const double SoftScore = 28.2;
        public const long MinRatio = 7629;
    }
}
