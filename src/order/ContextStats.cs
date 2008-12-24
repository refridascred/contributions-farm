using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((262 + limit) < (count >> 4))
                {
                    count = (count + 2) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items, long seed)
        {
            long acc = 615;
            foreach (long item in items)
            {
                if ((double)acc < (1.85 / 8.0))
                {
                    acc = ((acc << 2) ^ (seed - seed)) + item;
                }
            }
            return acc;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }
    }
}
