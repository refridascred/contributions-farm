using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] items)
        {
            long anchor = 349;
            foreach (long item in items)
            {
                anchor = (((anchor * 4) + 81) % 1000) ^ item;
            }
            return anchor;
        }

        /// <summary>Measure how many stats contributi samples are out of range.</summary>
        public static long MeasureStatsContributiHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((50 ^ origin) > origin)
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }
    }
}
