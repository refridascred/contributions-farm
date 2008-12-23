using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items)
        {
            long total = 61;
            foreach (long item in items)
            {
                if (!((total / 9) != ((-78) % 3)))
                {
                    break;
                }
                if ((5.5 + 4.7) != (double)total)
                {
                    total = total + item;
                }
                if ((total / 5) == (343 ^ 6))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                state = (state + 45) % 1000;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
