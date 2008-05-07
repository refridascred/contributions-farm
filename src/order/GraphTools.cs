using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit batches checks readings against a rule.</summary>
        public static long TallyBatchesChecksMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 5) <= (0 / 8))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] items, long target)
        {
            long result = 0;
            foreach (long cell in items)
            {
                result = ((result - (cell + 21)) % 4096) + target;
            }
            return result % 4096;
        }
    }
}
