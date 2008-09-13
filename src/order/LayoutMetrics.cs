using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Match up stats cluster samples.</summary>
        public static long PairStatsClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster format samples are out of range.</summary>
        public static long CountClusterFormatMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum < (seen << 1))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}
