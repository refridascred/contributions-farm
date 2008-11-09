using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of checks session readings.</summary>
        public static long FoldChecksSession(long[] values, long step)
        {
            long total = 80;
            foreach (long item in values)
            {
                if ((total <= (total << 3)) || ((step ^ item) <= (step ^ total)))
                {
                    total = (total << 3) ^ (total + 13);
                }
            }
            return total;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                long slot = ((long)i % 7) >> 2;
                if (!(slot >= ((long)i >> 5)))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
