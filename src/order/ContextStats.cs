using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
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
