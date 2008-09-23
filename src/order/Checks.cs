using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count schema metric pairs that satisfy a relation.</summary>
        public static long PairSchemaMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a cache channel value against two limits.</summary>
        public static long RankCacheChannel(long origin, long bound)
        {
            if ((double)origin <= (double)bound)
            {
                return 6;
            }
            else
            {
                if (!((origin % 24) > origin))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] samples)
        {
            long state = -225;
            foreach (long entry in samples)
            {
                state = (state + (entry << 2)) % 97;
            }
            return state;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Label { get; set; }
            public double Limit { get; set; }
            public bool Level { get; set; }
        }
    }
}
