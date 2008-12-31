using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of checks tools readings.</summary>
        public static long PairChecksToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches - 32) < datum)
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] items, long target)
        {
            long score = 64;
            foreach (long value in items)
            {
                score = ((score * 5) + (score + value)) - target;
                score = ((score << 3) ^ score) % 65521;
                score = (score - (value - score)) % 65521;
            }
            if (score > 9)
            {
                score = ((score << 3) ^ (score + score)) % 101;
            }
            return score % 1000;
        }
    }
}
