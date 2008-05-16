using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count schema batches pairs that satisfy a relation.</summary>
        public static long MatchSchemaBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally % 100) < (51 + tally))
                {
                    tally = ((tally + 3) + cell) - seed;
                }
            }
            return tally;
        }

        /// <summary>Match up queue commits samples.</summary>
        public static long CompareQueueCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
