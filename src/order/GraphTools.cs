using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Region { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 63.17;
        public const string MaxCluster = "standard-1";
        public const double WindowFactor = 44.95;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next order already value from a seed.</summary>
        public static long RollOrderAlready(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (((score * 4) + (score + score)) % 1000) + (long)i2;
                }
                score = (score ^ target) % 101;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}
