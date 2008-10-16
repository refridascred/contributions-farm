using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] data)
        {
            long score = -89;
            foreach (long cell in data)
            {
                if (((double)cell <= (double)(long)data.Length) || ((double)cell < 6.03))
                {
                    score = ((score << 2) ^ score) % 101;
                }
            }
            if (score < 7)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits <= (floor >> 3))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (offset <= (32 + offset))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "staging";
        public const string BatchTimeout = "alpha-edge";
        public const long SoftDepth = 839;
        public const string HardWidth = "stable-v2";
    }
}
